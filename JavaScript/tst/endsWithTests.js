describe('String.endsWith test:', function () {
    var str = 'hang the dj';

    it('`hang the dj`.endsWith(`dj`) should return true', function () {
        expect(str.endsWith('dj')).toBeTruthy();
    });

    it('`hang the dj`.endsWith(`panic on the streets`) should return false', function () {
        expect(str.endsWith('panic on the streets')).toBeFalsy();
    });

    it('`hang the dj`.endsWith(``) should return true', function () {
        expect(str.endsWith('')).toBeTruthy();
    });

    it('`hang the dj`.endsWith(`the dj`) should return true', function () {
        expect(str.endsWith('the dj')).toBeTruthy();
    });

    it('`hang the dj`.endsWith(`e dj`) should return true', function () {
        expect(str.endsWith('e dj')).toBeTruthy();
    });

    it('`hang the dj`.endsWith(`j`) should return true', function () {
        expect(str.endsWith('j')).toBeTruthy();
    });

    it('`hang the dj`.endsWith(42) should return false', function () {
        expect(str.endsWith(42)).toBeFalsy();
    });

    it('`hang the dj`.endsWith({ first: \'Johnny\' }) should return false', function () {
        expect(str.endsWith({ first: 'Johnny' })).toBeFalsy();
    });

    it('`hang the dj`.endsWith(null) should return false', function () {
        expect(str.endsWith(null)).toBeFalsy();
    });

    it('`hang the dj`.endsWith() should return false', function () {
        expect(str.endsWith()).toBeFalsy();
    });

    it('`அ ஆ இ ஈ உ ஊ எ ஏ ஐ`.endsWith(`எ ஏ ஐ`) should return true', function () {
        expect('அ ஆ இ ஈ உ ஊ எ ஏ ஐ'.endsWith(`எ ஏ ஐ`)).toBeTruthy();
    });

    it('`அ ஆ இ ஈ உ ஊ எ ஏ ஐ`.endsWith(`இ ஈ`) should return false', function () {
        expect('அ ஆ இ ஈ உ ஊ எ ஏ ஐ'.endsWith(`அ ஆ`)).toBeFalsy();
    });
});



