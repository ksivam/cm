describe('String.startsWith test:', function () {
    var str = 'hang the dj';

    it('`hang the dj`.startsWith(`hang`) should return true', function () {
        expect(str.startsWith('hang')).toBeTruthy();
    });

    it('`hang the dj`.startsWith(`Hang`) should return false', function () {
        expect(str.startsWith('Hang')).toBeFalsy();
    });

    it('`hang the dj`.startsWith(`I’ve got a room for rent`) should return false', function () {
        expect(str.startsWith('I’ve got a room for rent')).toBeFalsy();
    });

    it('`hang the dj`.startsWith(``) should return true', function () {
        expect(str.startsWith('')).toBeTruthy();
    });

    it('`hang the dj`.startsWith(`hang the`) should return true', function () {
        expect(str.startsWith('hang the')).toBeTruthy();
    });

    it('`hang the dj`.startsWith(`han`) should return true', function () {
        expect(str.startsWith('han')).toBeTruthy();
    });

    it('`hang the dj`.startsWith(`hang t`) should return true', function () {
        expect(str.startsWith('hang t')).toBeTruthy();
    });

    it('`hang the dj`.startsWith(42) should return false', function () {
        expect(str.startsWith(42)).toBeFalsy();
    });

    it('`hang the dj`.startsWith({ first: \'Johnny\' }) should return false', function () {
        expect(str.startsWith({ first: 'Johnny' })).toBeFalsy();
    });

    it('`hang the dj`.startsWith(null) should return false', function () {
        expect(str.startsWith(null)).toBeFalsy();
    });

    it('`hang the dj`.startsWith() should return false', function () {
        expect(str.startsWith()).toBeFalsy();
    });

    it('`அ ஆ இ ஈ உ ஊ எ ஏ ஐ`.startsWith(`அ ஆ இ`) should return true', function () {
        expect('அ ஆ இ ஈ உ ஊ எ ஏ ஐ'.startsWith(`அ ஆ இ`)).toBeTruthy();
    });

    it('`அ ஆ இ ஈ உ ஊ எ ஏ ஐ`.startsWith(`இ ஈ`) should return false', function () {
        expect('அ ஆ இ ஈ உ ஊ எ ஏ ஐ'.startsWith(`இ ஈ`)).toBeFalsy();
    });
});



