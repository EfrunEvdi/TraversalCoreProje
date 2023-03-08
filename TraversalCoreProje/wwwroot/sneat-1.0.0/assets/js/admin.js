$("#cityBtnGetList").click(function () {
    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "Get",
        url: "/Admin/City/CityList",
        success: function (data) {
            let dataParse = jQuery.parseJSON(data);
            console.log(dataParse);
            let tablehtml = "<table class= table table-hover text - center> <thead><tr><th> ŞEHİR ADI </th> <th> GECE / GÜN </th> <th> FİYAT </th> </tr></thead>";
            $.each(dataParse, (index, value) => {
                tablehtml += `<tbody class="table-border-bottom-0 text-center"> <tr><td>${value.City}</td><td>${value.DayNight}</td> <td>${value.Price} ₺</td></tr></tbody>`
            });
            tablehtml += "</table>";
            $("#citylist").html(tablehtml);
        }
    });
});

$("#cityBtnAddCity").click(function () {
    let cityvalues = {
        City: $("#txtcity").val(),
        DayNight: $("#txtdaynight").val(),
        Price: $("#txtprice").val(),
        Capacity: $("#txtcapacity").val()
    };

    $.ajax({
        type: "post",
        url: "/Admin/City/AddCityDestination/",
        data: cityvalues,
        success: function (data) {
            let result = jQuery.parseJSON(data);
            alert("Şehir - Rota başarılı bir şekilde eklendi.")
        }
    });
});

$("#cityBtnGetByID").click(x => {
    let id = $("#txtid").val();

    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "Get",
        url: "/Admin/City/GetByID",
        data: { DestinationID: id },
        success: function (data) {
            let result = jQuery.parseJSON(data);
            console.log(result);
            let htmlstr = `<table class= table table-hover text-center> <thead><tr><th> ŞEHİR ADI </th> <th> GECE / GÜN </th> <th> FİYAT </th> </tr></thead>
             <tbody class="table-border-bottom-0 text-center"> <tr><td>${result.City}</td><td>${result.DayNight}</td> <td>${result.Price} ₺</td></tr></tbody>`;
            $("#destinationListByID").html(htmlstr);
        }
        //error: function (data) {
        //    $("#message").html("<div><p>Girmiş olduğunuz ID değerinde kayıtlı şehir bulunamadı.. </p></div>");
        //}
    });
});

$("#cityBtnDeleteCity").click(x => {
    let id = $("#txtcityid").val();

    $.ajax({
        url: "/Admin/City/DeleteCity/" + id,
        type: "post",
        contentType: "application/json",
        dataType: "json",
        success: function (data) {
            alert("Silme işlemi yapıldı.")
        }
    });
});

$("#cityBtnUpdateCity").click(function () {
    let values = {
        DestinationID: $("#txtcityeditid").val(),
        City: $("#txtcityname").val(),
        DayNight: $("#txtcitydaynight").val()
    };

    $.ajax({
        type: "post",
        url: "/Admin/City/UpdateCity",
        data: values,
        success: function (data) {
            alert("Güncelleme işlemi yapıldı.")
        }
    });
});