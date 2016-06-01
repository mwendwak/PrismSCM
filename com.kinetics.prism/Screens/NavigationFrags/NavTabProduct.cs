using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using com.kinetics.prism.Models;

namespace com.kinetics.prism
{
    class NavTabProduct: Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            /*CAPTURE PAGE ELEMENTS*/
                var view = inflater.Inflate(Resource.Layout.Menu_Products, container, false);
                var btnGenProducts = view.FindViewById<Button>(Resource.Id.genProducts);
            /*PAGE ELEMENTS*/

            /*HANDLE VIEW EVENTS HERE*/
                btnGenProducts.Click += delegate {
                    Product tempProd = new Product();
                    tempProd =  Product.createProduct();
                    Product.insertProduct(tempProd);
            };
            /*HANDLE VIEW EVENTS*/
            return view;
        }

    }
}