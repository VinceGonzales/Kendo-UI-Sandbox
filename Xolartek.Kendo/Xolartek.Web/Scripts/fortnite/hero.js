/// <reference path="../Kendo/2018.2.620/kendo.all.min.js" />
var apiUrl = "http://localhost:50090/api/Fortnite/Heroes/" + dto.Id;
var skillDTO = {
    id: { type: "number" },
    name: { type: "string" },
    classname: { type: "string" },
    description: { type: "string" },
    heroname: { type: "string" },
    issupport: { type: "boolean" },
    istactical: { type: "boolean" }
};
var skillModel = kendo.data.Model.define({ id: "Id", fields: skillDTO });
window.dsHero = new kendo.data.DataSource({
    autoSync: true,
    transport: {
        read: { dataType: "json", type: "get", url: apiUrl }
    },
    schema: { data: "Skills", model: skillModel }
});
$("#pnlGrid").kendoGrid({
    dataSource: dsHero,
    columns: [
        { width: 80, field: "id", title: " ", hidden: true },
        { width: 80, field: "name", title: "Skill" },
        { width: 80, field: "description", title: "Description" }
    ],
    dataBound: function (e) {
        var rows = e.sender.tbody.children();
        for (var j = 0; j < rows.length; j++) {
            var row = $(rows[j]);
            var dataItem = e.sender.dataItem(row);
            var isTactical = dataItem.get("istactical");
            if (isTactical) {
                row.addClass("row-tactical");
            }
        }
    },
    height: 500
});
$(function () {
    var viewModel = kendo.observable(dto);
    dsHero.read();
    kendo.bind($("#pnlDetail"), viewModel);
});
