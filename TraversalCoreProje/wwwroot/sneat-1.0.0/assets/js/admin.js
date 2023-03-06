$("#cityBtnGetList").click(function () {
    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "Get",
        url: "/Admin/City/CityList",
        success: function (data) {
            let dataParse = jQuery.parseJSON(data);
            console.log(dataParse);
            let tablehtml = "<table class= table table-hover text - center> <thead><tr><th> ŞEHİR ID </th> <th> ŞEHİR ADI </th> <th> ÜLKE ADI </th> </tr></thead>";
            $.each(dataParse, (index, value) => {
                tablehtml += `<tbody class="table-border-bottom-0 text-center"> <tr><td>${value.CityID}</td><td>${value.CityName}</td> <td>${value.CityCountry}</td></tr></tbody>`
            });
            tablehtml += "</table>";
            $("#citylist").html(tablehtml);
        }
    });
});
