namespace Xolartek {
    export class Utils {
        public ApplicationName: string;
        constructor() {
            this.ApplicationName = "";
        }
        public GenerateGUID(): string {
            var result: string = 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c: any): string {
                var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
                return v.toString(16);
            });
            return result;
        }
    }
}