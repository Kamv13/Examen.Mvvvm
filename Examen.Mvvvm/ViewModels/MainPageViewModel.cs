using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Examen_Mvvm.ViewModels
    {
        public partial class MainPageViewModel : ObservableObject
        {
           
            [ObservableProperty]
            private string producto1;

            [ObservableProperty]
            private string producto2;

            [ObservableProperty]
            private string producto3;

            
            [ObservableProperty]
            private string subtotal;

            [ObservableProperty]
            private string descuento;

            [ObservableProperty]
            private string total;

          
            [RelayCommand]
            private void Calcular()
            {
                
                double.TryParse(Producto1, out double prod1);
                double.TryParse(Producto2, out double prod2);
                double.TryParse(Producto3, out double prod3);

                double subtotalCalculado = prod1 + prod2 + prod3;
                double descuentoCalculado = 0;

               
                if (subtotalCalculado >= 1000 && subtotalCalculado < 5000)
                    descuentoCalculado = subtotalCalculado * 0.10;
                else if (subtotalCalculado >= 5000 && subtotalCalculado < 10000)
                    descuentoCalculado = subtotalCalculado * 0.20;
                else if (subtotalCalculado >= 10000)
                    descuentoCalculado = subtotalCalculado * 0.30;

                double totalCalculado = subtotalCalculado - descuentoCalculado;

                Subtotal = subtotalCalculado.ToString("F2");
                Descuento = descuentoCalculado.ToString("F2");
                Total = totalCalculado.ToString("F2");
            }

            
            [RelayCommand]
            private void Limpiar()
            {
                Producto1 = string.Empty;
                Producto2 = string.Empty;
                Producto3 = string.Empty;
                Subtotal = string.Empty;
                Descuento = string.Empty;
                Total = string.Empty;
            }
        }
    }


