type StringNumberOrBoolean = string | number | boolean;
type msgCallback = (string) => void;

namespace Xolartek {
    export class Utils {
        private myMessageCallback: msgCallback;
        public setCallback(callback: msgCallback) {
            this.myMessageCallback = callback;
        }
        public outputMessage(msg: StringNumberOrBoolean): void
        public outputMessage(msg: any): void {
            if (this.myMessageCallback) {
                this.myMessageCallback(msg);
            } else {
                document.getElementById("pnlMessage").innerHTML += msg + "<br />";
            }
        }
        public GenerateGUID(): string {
            var result: string = 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c: any): string {
                var r: number = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
                return v.toString(16);
            });
            return result;
        }
    }
}