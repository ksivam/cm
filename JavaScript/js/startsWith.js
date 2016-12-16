(function (String, undefined) {
    'use strict';

    // NOTE: Tested only in Chrome browser.
    var startsWith = function (input) {
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

        var index = -1;
        while (++index < inputString.length) {
            // Ref: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/charCodeAt
            if (srcString.charCodeAt(index) !== inputString.charCodeAt(index)) {
                return false;;
            }
        }

        return true;
    };

    String.prototype.startsWith = startsWith;
})(String);