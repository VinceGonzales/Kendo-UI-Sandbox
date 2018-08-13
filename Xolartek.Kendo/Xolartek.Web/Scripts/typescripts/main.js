var Xolartek;
(function (Xolartek) {
    var Utils = (function () {
        function Utils() {
            this.ApplicationName = "";
        }
        Utils.prototype.GenerateGUID = function () {
            var result = 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
                var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
                return v.toString(16);
            });
            return result;
        };
        return Utils;
    }());
    Xolartek.Utils = Utils;
})(Xolartek || (Xolartek = {}));
var utilities = new Xolartek.Utils();
window.onload = function () {
    var pnlMsg = document.getElementById('pnlMessage');
    var result = utilities.GenerateGUID();
    pnlMsg.innerHTML = "<h5>" + result + "</h5>";
    utilities.ApplicationName = "Xolartek-Kendo";
    console.log(utilities.ApplicationName);
};
System.register("gridoptns", [], function (exports_1, context_1) {
    "use strict";
    var GridOpts;
    var __moduleName = context_1 && context_1.id;
    return {
        setters: [],
        execute: function () {
            GridOpts = (function () {
                function GridOpts() {
                }
                return GridOpts;
            }());
            exports_1("default", GridOpts);
        }
    };
});
//# sourceMappingURL=C:/Users/LADBSCID11/Source/Repos/Kendo-UI-Sandbox/Xolartek.Kendo/Xolartek.Web/Scripts/typescripts/main.js.map