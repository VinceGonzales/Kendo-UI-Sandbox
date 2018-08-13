/// <reference path="./utils.ts" />

var utilities: any = new Xolartek.Utils();

window.onload = function () {
    var result = utilities.GenerateGUID();
    utilities.outputMessage(`<h5>${result}</h5>`);
    utilities.ApplicationName = "Xolartek-Kendo";
    utilities.setCallback(LogMessage);
    utilities.outputMessage(utilities.ApplicationName);
}
function LogMessage(message: string) {
    console.log(message);
}
