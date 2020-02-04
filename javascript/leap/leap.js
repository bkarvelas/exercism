//
// This is only a SKELETON file for the "Leap" exercise. It's been provided as a
// convenience to get you started writing code faster.
//

var Year = function (inputYear) 
{
    this.inputYear = inputYear;

};

Year.prototype.isLeap = function () 
{
    if(this.inputYear % 4 === 0)
    {
        if (this.inputYear % 100 === 0)
        {
            if(this.inputYear % 400 === 0)
            {
                return true;
            }
            return false;
        }
        return true;
    } else {
        return false;
    }
};

module.exports = Year;
