const translation = 
{
    'G' : 'C',
    'C' : 'G',
    'T' : 'A',
    'A' : 'U'
}
var DnaTranscriber = function () {};

DnaTranscriber.prototype.toRna = function (strDna)  {
    var resultRna = '';
    strDna.split('').forEach(nuc => {
        if (nuc in translation)
        {
            resultRna += translation[nuc];
        } else {
            throw new Error('Invalid input');
        }
    });
    return resultRna;
};

module.exports = DnaTranscriber;