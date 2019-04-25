using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cItemPricer : MonoBehaviour
{
    #region PUBLIC PROPERTIES

    [Range(0, 100)]
    public int _Dollars;
    [Range(0, 1)]
    public int _HalfDollars;
    [Range(0, 1)]
    public int _Quarters;
    [Range(0, 4)]
    public int _Dimes;
    [Range(0, 1)]
    public int _Nickels;
    [Range(0, 4)]
    public int _Pennies;

    public TextMeshPro _textMesh;

    public decimal Price
    {
        get { return _price; }
        set
        {
            _price = value;
            _textMesh.text = $"{_price:C}";
        }
    }
    #endregion

    #region PRIVATE PROPERTIES

    decimal _price;

    #endregion

    #region MONOBEHAVIOR

    private void OnEnable()
    {
        SetPrice();
    }

    #endregion

    #region PRIVATE METHODS

    /// <summary>
    /// Return an integer range between 0 and max,
    /// including both 0 and max.
    /// </summary>
    /// <param name="max"></param>
    /// <returns></returns>
    int Range(int max)
    {
        return Random.Range(0, max + 1);
    }

    /// <summary>
    /// Set a random price, based on the (current) currency 
    /// settings.
    /// </summary>
    void SetPrice()
    {

        decimal price = 0;

        while (price < (decimal).01)
        {
            //Range(): returns random int, 0 to passed arg, inclusive.
            int dollars = Range(_Dollars);
            int halfDollars = Range(_HalfDollars);
            int quarters = Range(_Quarters);
            int dimes = Range(_Dimes);
            int nickels = Range(_Nickels);
            int pennies = Range(_Pennies);

            price = (decimal)(dollars);
            price += (decimal)(halfDollars * .50f);
            price += (decimal)(quarters * .25f);
            price += (decimal)(dimes * .10f);
            price += (decimal)(nickels * .05f);
            price += (decimal)(pennies * .01f);
        }

        Price = price;
    }

    #endregion

}
