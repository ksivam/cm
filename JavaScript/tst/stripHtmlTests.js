describe('String.stripHtml test:', function () {

    it('`<p>Shoplifters of the World< em > Unite</em >!</p >`.stripHtml() should return `Shoplifters of the World Unite!`', function () {
        var str = '<p>Shoplifters of the World< em > Unite</em >!</p >';
        expect(str.stripHtml()).toBe('Shoplifters of the World Unite!');
    });

    it('`1 &lt; 2`.stripHtml() should return `1 &lt; 2`', function () {
        var str = '1 &lt; 2';
        expect(str.stripHtml()).toBe('1 &lt; 2');
    });

    it('`<html>Hello`.stripHtml() should return `Hello`', function () {
        var str = '<html>Hello';
        expect(str.stripHtml()).toBe('Hello');
    });

    it('`</html>World`.stripHtml() should return `World`', function () {
        var str = '</html>World';
        expect(str.stripHtml()).toBe('World');
    });

    it('`html>World`.stripHtml() should return `html>World`', function () {
        var str = 'html>World';
        expect(str.stripHtml()).toBe('html>World');
    });

    it('`<a src=`http://images/icon.ico`>anchor element</a>`.stripHtml() should return `anchor element`', function () {
        var str = '<a src=`http://images/icon.ico`>anchor element</a>';
        expect(str.stripHtml()).toBe('anchor element');
    });

    it('`<text>Unicode chars: </text><p>அ ஆ இ</p>`.stripHtml() should return `Unicode chars: அ ஆ இ`', function () {
        var str = '<text>Unicode chars: </text><p>அ ஆ இ</p>';
        expect(str.stripHtml()).toBe('Unicode chars: அ ஆ இ');
    });

    it('`<XmlTag>Xml tag</XmlTag>`.stripHtml() should return `Xml tag`', function () {
        var str = '<XmlTag>Xml tag</XmlTag>';
        expect(str.stripHtml()).toBe('Xml tag');
    });

});



