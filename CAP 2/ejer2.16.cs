espacio de nombres  ejericio4
{
     programa de clases  publicas
    {
         vacío estático  público principal () 
        {

             contador int ;
             límite int ;
            int  sumatoria ;
            sumatoria  =  0 ;
            contador  =  1 ;
            limite  =  10 ;


            for ( contador  =  1 ; contador  <=  limite ; contador ++ )
            {
                sumatoria  =  sumatoria  +  contador ;
            }

            consola _ WriteLine ( $" la suma es igual:{ sumatoria } " );



        }
    }
}
