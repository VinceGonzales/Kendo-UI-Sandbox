/// <reference path="./utils.ts" />

var utilities: any = new Xolartek.Utils();

window.onload = function () {
    var pnlMsg = document.getElementById('pnlMessage');
    var result = utilities.GenerateGUID();
    pnlMsg.innerHTML = `<h5>${result}</h5>`;
    utilities.ApplicationName = "Xolartek-Kendo";
    console.log(utilities.ApplicationName);
}
