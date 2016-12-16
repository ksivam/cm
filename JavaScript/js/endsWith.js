(function (String, undefined) {
    'use strict';

    // NOTE: Tested only in Chrome browser.
    var endsWith = function (input) {
        if (input === null ||
            input === undefined) {
            // handle null and undefined values.
            return false;
        }

        var srcString = String(this);
        var inputString = String(input);

        if (srcString.length < inputString.length) {
            return false;
        }

        var inputStringIndex = inputString.length;
        var srcStringIndex = srcString.length;
        while (--inputStringIndex >= 0 && --srcStringIndex) {
            // Ref: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/charCodeAt
            if (srcString.charCodeAt(srcStringIndex) !== inputString.charCodeAt(inputStringIndex)) {
                return false;
            }
        }

        return true;
    };

    String.prototype.endsWith = endsWith;

})(String);