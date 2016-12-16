(function (String, undefined) {
    'use strict';

    // NOTE: Tested only in Chrome browser.
    var stripHtml = function () {
        var srcString = String(this);

        // Ref: https://regex101.com/r/J9aZ3s/7
        var regex = /<.*?>/gu;
        return srcString.replace(regex, '');

    };

    String.prototype.stripHtml = stripHtml;
})(String);