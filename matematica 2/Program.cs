double diferencia = 0, razon = 0, PrimerT = 0, Termino = 0, potencia = 0, Clasificar = 0;
int top = 3, top2 = 2, limpiar = 0, Tipo = 0, ipar = 0, iinpar = 0, contCre = 0, contDe = 0, contCon = 0, fin = 0;
string par = "";
string impar = "";
string Resultados = "";
int select = 0, select1 = 0;
while (top == 3)
{
    Console.WriteLine("¡Qué accíon desea realizar?: \n 1- Calcular alguna sucesión \n 2- Identificar el tipo de sucesion \n 3- Salir ");

    select = Convert.ToInt32(Console.ReadLine());

    switch (select)
    {
        case 1:
            Console.WriteLine("Qué tipo de Sucesion desea Calcular: \n 1- Sucesion aritmetica \n 2- Sucesion geometrica");
            select1 = Convert.ToInt32(Console.ReadLine());
            switch (select1)
            {
                case 1:
                    {
                        Console.WriteLine("¿Qué desea calcular de la Sucesion arimetrica? : \n 1- término General \n 2- la diferencia ");
                        select = Convert.ToInt32(Console.ReadLine());
                        if (select == 1)
                        {
                            Console.WriteLine("Por favor ingrese el primer término (a1) de la Sucesion :");
                            PrimerT = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Por favor ingrese la diferencia (d) de la Sucesion :");
                            diferencia = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("(¡ADVERTENCIA!)\n (No se recomienda ingresar datos, que sus resultados superen los 320 digitos, de ser el caso el programa dejara de contabilizarlo)\n");
                            Console.WriteLine("Por favor ingrese la cantidad de terminos que quieres que tenga tu sucesion:  ");
                            top2 = Convert.ToInt32(Console.ReadLine());
                            double[] Sari = new double[top2];
                            for (int i = 0; i < top2; i++)
                            {
                                if (i == 0)
                                {
                                    Termino = (double)PrimerT + ((double)diferencia);
                                }
                                else if (i > 0)
                                {
                                    Termino = (double)Termino + ((double)diferencia);
                                }
                                Sari[i] = Termino;
                                if (Termino != 0)
                                {
                                    Resultados = Resultados + "\nEl " + (i + 1) + " término general es : " + ((double)Termino);
                                    if (Math.Truncate(Termino) % 2 == 0)
                                    {
                                        par = par + "\nEl " + (ipar + 1) + " término general par es : " + ((double)Termino);
                                        ipar++;
                                    }

                                    if (Math.Truncate(Termino) % 2 != 0)
                                    {
                                        impar = impar + "\nEl " + (iinpar + 1) + " término general impar es : " + ((double)Termino);
                                        iinpar++;
                                    }
                                }
                                else if (Termino == 0 & PrimerT != 0)
                                {
                                    i = top2;
                                    Resultados = Resultados + "\nSe a superado los 320 terminos, el programa a dejado de contabilizar los terminos que siguen";
                                    if (Math.Truncate(Termino) % 2 == 0)
                                    {
                                        par = par + "\nSe a superado los 320 terminos, el programa a dejado de contabilizar los terminos que siguen";
                                        ipar++;
                                    }

                                    if (Math.Truncate(Termino) % 2 != 0)
                                    {
                                        impar = impar + "\nSe a superado los 320 terminos, el programa a dejado de contabilizar los terminos que siguen";
                                        iinpar++;
                                    }
                                }

                                if (Clasificar == 0)
                                {

                                    Clasificar = Termino;

                                }

                                else if (Termino == Clasificar)
                                {

                                    Clasificar = Termino;
                                    contCon++;
                                }
                                else if (Termino > Clasificar)
                                {

                                    Clasificar = Termino;
                                    contCre++;

                                }
                                else if (Termino < Clasificar)
                                {

                                    Clasificar = Termino;
                                    contDe++;
                                }

                            }
                            Console.WriteLine("Desea que los resultados sean pares o impares, o le da igual:\n (Opciones)\n 1- Par \n2- Impar \n3- Ambos resultados ");
                            Tipo = Convert.ToInt32(Console.ReadLine());
                            if (Tipo == 1)
                            {
                                Console.WriteLine(par);
                            }
                            if (Tipo == 2)
                            {
                                Console.WriteLine(impar);
                            }
                            if (Tipo == 3)
                            {
                                Console.WriteLine(Resultados);
                            }

                            if (EsAlternante2(Sari))
                            {
                                Console.WriteLine("La sucecion es alternante.");

                            }
                            if (contCre == contCon)
                            {

                            }
                            else if (contDe == contCon)
                            {

                            }
                            else if (contCon > (contCre & contDe))
                            {
                                Console.WriteLine("La sucecion es constante.");
                            }
                            if (contCon == contCre)
                            {

                            }
                            else if (contDe == contCre)
                            {

                            }
                            else if (contCre == top2)
                            {
                                Console.WriteLine("La sucecion es estrictamente creciente.");
                            }
                            else if (contCre > (contDe & contCon))
                            {
                                Console.WriteLine("La sucecion es creciente.");
                            }
                            else if (contDe == contCre)
                            {

                            }
                            else if (contCon == contDe)
                            {

                            }
                            else if (contDe == top2)
                            {
                                Console.WriteLine("La Sucesion es estrictamente decreciente.");
                            }
                            else if (contDe > (contCre & contCon))
                            {
                                Console.WriteLine("La sucecion es decreciente.");
                            }
                            Tipo = 0;
                            par = "";
                            impar = "";
                            Resultados = "";
                        }
                        if (select == 2)
                        {
                        Console.WriteLine("A continuacion debera ingresar 2 terminos concecutivos , de su sucesion , para poder calcular la diferencia :");
                            top2 = 2;
                                double[] v = new double[top2];
                                for (int i = 0; i < top2; i++)
                                {
                                    Console.WriteLine("Ingrese el " + (i + 1) + " término  de su sucesion");
                                    v[i] = Convert.ToDouble(Console.ReadLine());

                                }
                                diferencia = (v[1]) - v[0];
                                Console.WriteLine("La diferencia  (d) de la sucesión es : " + diferencia);
                          
                        }
                        break;
                    }


                case 2:

                    Console.WriteLine("¿Que le gustaria calcular de la sucesion geometrica?\n Opciones: \n 1- Termino general \n 2- Razón");
                    select = Convert.ToInt32(Console.ReadLine());
                    if (select == 1)
                    {
                        Console.WriteLine("(¡ADVERTENCIA!)\n (No se recomienda ingresar datos, que sus resultados superen los 320 digitos, de ser el caso el programa dejara de contabilizarlo)\n");
                        Console.WriteLine("Por favor Ingrese el primer termino (a1) de la sucesión :");
                        PrimerT = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Por favor ingrese la razón (r) de la sucesión :");
                        razon = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Por favor ingrese la cantidad de terminos que desea calcular :  ");
                        top2 = Convert.ToInt32(Console.ReadLine());
                        double[] SGeo = new double[top2];
                        for (int i = 0; i < top2; i++)
                        {

                            if (i == 0)
                            {
                                Termino = (double)PrimerT * ((double)razon);
                            }
                            else if (i > 0)
                            {
                                Termino = (double)Termino * ((double)razon);
                            }
                            SGeo[i] = Termino;
                            if (Termino != 0)
                            {
                                Resultados = Resultados + "\nEl " + " término general es : " + ((double)Termino);
                                if (Math.Truncate(Termino) % 2 == 0)
                                {
                                    par = par + "\nEl " + " término general par es : " + ((double)Termino);
                                    ipar++;
                                }

                                if (Math.Truncate(Termino) % 2 != 0)
                                {
                                    impar = impar + "\nEl " + " término general impar es : " + ((double)Termino);
                                    iinpar++;
                                }
                            }
                            else if (Termino == 0 & PrimerT != 0)
                            {
                                i = top2;
                                Resultados = Resultados + "\nSe a superado los 320 terminos, el programa a dejado de contabilizar los terminos que siguen";
                                if (Math.Truncate(Termino) % 2 == 0)
                                {
                                    par = par + "\nSe a superado los 320 terminos, el programa a dejado de contabilizar los terminos que siguen";
                                    ipar++;
                                }

                                if (Math.Truncate(Termino) % 2 != 0)
                                {
                                    impar = impar + "\nSe a superado los 320 terminos, el programa a dejado de contabilizar los terminos que siguen";
                                    iinpar++;
                                }
                            }


                            if (Clasificar == 0)
                            {

                                Clasificar = Termino;

                            }

                            else if (Termino == Clasificar)
                            {

                                Clasificar = Termino;
                                contCon++;
                            }
                            else if (Termino > Clasificar)
                            {

                                Clasificar = Termino;
                                contCre++;

                            }
                            else if (Termino < Clasificar)
                            {

                                Clasificar = Termino;
                                contDe++;
                            }

                        }
                        Console.WriteLine("Desea que los resultados sean pares o impares, o le da igual:\n (Opciones)\n 1- Par \n2- Impar \n3- Ambos resultados ");
                        Tipo = Convert.ToInt32(Console.ReadLine());
                        if (Tipo == 1)
                        {
                            Console.WriteLine(par);
                        }
                        if (Tipo == 2)
                        {
                            Console.WriteLine(impar);
                        }
                        if (Tipo == 3)
                        {
                            Console.WriteLine(Resultados);
                        }

                        if (EsAlternante1(SGeo))
                        {
                            Console.WriteLine("La sucecion es alternante.");
                            
                        }
                        if (contCre == contCon)
                        {

                        }
                        else if (contDe == contCon)
                        {

                        }
                        else if (contCon > (contCre & contDe))
                        {
                            Console.WriteLine("La sucecion es constante.");
                        }
                        if (contCon == contCre)
                        {

                        }
                        else if (contDe == contCre)
                        {

                        }
                        else if (contCre == top2)
                        {
                            Console.WriteLine("La sucecion es estrictamente creciente.");
                        }
                        else if (contCre > (contDe & contCon))
                        {
                            Console.WriteLine("La sucecion es creciente.");
                        }
                        else if (contDe == contCre)
                        {

                        }
                        else if (contCon == contDe)
                        {

                        }
                        else if (contDe == top2)
                        {
                            Console.WriteLine("La Sucesion es estrictamente decreciente.");
                        }
                        else if (contDe > (contCre & contCon))
                        {
                            Console.WriteLine("La sucecion es decreciente.");
                        }
                        Tipo = 0;
                        par = "";
                        impar = "";
                        Resultados = "";
                        contDe = 0;
                        contCre = 0;
                        contCon = 0;
                        Clasificar = 0;
                    }
                    if (select==2)
                       {
                        Console.WriteLine("A continuacion debera ingresar 2 terminos concecutivos , de su sucesion , para poder calcular la razón :"); 
                            double[] v = new double[top2];
                        top2 = 2;
                            for (int i = 0; i < top2; i++)
                            {
                                Console.WriteLine("Ingrese el " + (i + 1) + " término  de su sucesion");
                                v[i] = Convert.ToDouble(Console.ReadLine());

                            }
                            razon = (v[1]) / v[0];
                        Console.WriteLine("La razon  (r)  de la sucesión es : " + razon);
                        }
                    break;
            }
                              


                    


            
           break;
        case 2:
            {
                Console.WriteLine("Ingresa cuantos términos va tener tu sucesión (La suceción tiene que tener minimo 3 numeros) :");
                top2 = Convert.ToInt32(Console.ReadLine());
                double[] Sucesion = new double[top2];
                if (top2 < 3)
                {
                    Console.WriteLine("Usted a ingresado menos de 3 términos, no es posible calcular la sucesión");
                }
                if (top2 >= 3)
                {
                    for (int i = 0; i < top2; i++)
                    {
                        Console.WriteLine("Ingresa el " + (i + 1) + " de tu Sucesión \nSi desea ingresar un numero decimal, utilice la coma (,) :");
                        Sucesion[i] = Convert.ToDouble(Console.ReadLine());
                        if (Clasificar == 0)
                        {

                            Clasificar = Sucesion[i];

                        }

                        else if (Sucesion[i] == Clasificar)
                        {

                            Clasificar = Sucesion[i];
                            contCon++;
                        }
                        else if (Sucesion[i] > Clasificar)
                        {

                            Clasificar = Sucesion[i];
                            contCre++;

                        }
                        else if (Sucesion[i] < Clasificar)
                        {

                            Clasificar = Sucesion[i];
                            contDe++;
                        }

                    }
  

                    if (EsAritmetica(Sucesion))
                       Resultados="La sucesión es aritmética";
                    else if (EsGeometrica(Sucesion))
                        Resultados= "La sucesión es geométrica";
                    else Resultados ="La sucesión no es ni aritmética ni geométrica";

                    if (EsAlternante(Sucesion))
                    {
                        Resultados= Resultados+"y "+"es alternante.";
                    }
                    if (contCre == contCon)
                    {

                    }
                    else if (contDe == contCon)
                    {

                    }
                    else if (contCon > (contCre & contDe))
                    {
                        Resultados = Resultados + "y "+"es constante.";
                    }
                    if (contCon == contCre)
                    {

                    }
                    else if (contDe == contCre)
                    {

                    }
                    else if (contCre == top2)
                    {
                        Resultados = Resultados + "y " + "es estrictamente creciente.";
                    }
                    else if (contCre > (contDe & contCon))
                    {
                        Resultados = Resultados + "y " + "es creciente.";
                    }
                    else if (contDe == contCre)
                    {

                    }
                    else if (contCon == contDe)
                    {

                    }
                    else if (contDe == top2)
                    {
                        Resultados = Resultados + "y " + "es estrictamente decreciente.";
                    }
                    else if (contDe > (contCre & contCon))
                    {
                        Resultados = Resultados + "y " + "es decreciente.";
                    }

                    Console.WriteLine(Resultados);
                    contDe = 0;
                    contCre = 0;
                    contCon = 0;
                    Clasificar = 0;
                }
            }
            break;

        case 3:
            {
                Console.WriteLine("¡Gracias por utilizar el programa!");
                top++;
                fin = 1;
            }
            break;
    }


    if (select > 3)
    {
        Console.WriteLine("El numero ingresado no es valido, por favor intentelo de nuevo");
    }
    if (select < 1)
    {
        Console.WriteLine("El numero ingresado no es valido, por Favor intentelo de nuevo");
    }
    if (fin == 0)
    {
        Console.WriteLine("¿Desea realizar otra operación? : \n 1)- Si \n 2)- No");

        limpiar = Convert.ToInt32(Console.ReadLine());
        switch (limpiar)
        {
            case 1:
                Console.Clear();
                break;
            case 2:
                Console.WriteLine("¡Gracias por utilizar el el programa!");
                top++;
                break;

        }
    }
}
            





            static bool EsGeometrica(double[] Sucesion)
            {
                double razon = (double)Sucesion[1] / Sucesion[0];
                for (int i = 2; i < Sucesion.Length; i++)
                {
                    if ((double)Sucesion[i] / Sucesion[i - 1] != razon)
                        return false;
                }
                return true;
            }

            static bool EsAritmetica(double[] Sucesion)
            {
                double diferencia = Sucesion[1] - Sucesion[0];
                for (int i = 2; i < Sucesion.Length; i++)
                {
                    if (Sucesion[i] - Sucesion[i - 1] != diferencia)
                        return false;
                }
                return true;
            }

            static bool EsAlternante(double[] Sucesion)
            {
                for (int i = 1; i < Sucesion.Length; i++)
                {
                    // Verifica si el signo de cada término es diferente del anterior
                    if (Math.Sign(Sucesion[i]) == Math.Sign(Sucesion[i - 1]))
                        return false;
                }
                return true;
            }

static bool EsAlternante1(double[] SGeo)
{
    for (int i = 1; i < SGeo.Length; i++)
    {
        // Verifica si el signo de cada término es diferente del anterior
        if (Math.Sign(SGeo[i]) == Math.Sign(SGeo[i - 1]))
            return false;
    }
    return true;
}

static bool EsAlternante2(double[] Sari)
{
    for (int i = 1; i < Sari.Length; i++)
    {
        // Verifica si el signo de cada término es diferente del anterior
        if (Math.Sign(Sari[i]) == Math.Sign(Sari[i - 1]))
            return false;
    }
    return true;
}