using System;
using System.Collections.Generic;
using System.Text;

namespace extenso
{
    class Extenso
    {
    public String convert(int i)
    {
        String valor = Convert.ToString(i);
        if (valor.Length.Equals(1))
        {
            valor = "00" + valor;
        }
        else if (valor.Length.Equals(1))
        {
            valor = "0" + valor;
        }
        String retorno = "Valor inválido";
        if (i > 0 && i < 1000)
        {
            retorno = "";
            if (i > 100)
            {
                String centena = Convert.ToString(valor.Substring(0,0));
                retorno = retorno + getCentena(centena);
                i = i - int.Parse(centena + "00");
                if (i > 0)
                {
                    retorno = retorno + " e ";
                }
            }
            else if (i == 100)
            {
                retorno = valorPeculiar(100);
                i = 0;
            }
            if (i >= 20 || i == 10)
            {
                String dezena = Convert.ToString(valor.Substring(1,0));
                retorno = retorno + getDezena(dezena);
                i = i - int.Parse(dezena + "0");
                if (i > 0)
                {
                    retorno = retorno + " e ";
                }
            }
            else if (i > 10 && i < 20)
            {
                retorno = retorno + valorPeculiar(i);
                i = 0;
            }
            if (i > 0)
            {
                String unidade = Convert.ToString(valor.Substring(2,0));
                retorno = retorno + getUnidade(unidade);
            }
        }
        return retorno;
    }

    private String valorPeculiar(int i)
    {
        switch (i)
        {
            case 100: return "cem";
            case 11: return "onze";
            case 12: return "doze";
            case 13: return "treze";
            case 14: return "quatorze ";
            case 15: return "quinze";
            case 16: return "dezesseis";
            case 17: return "dezessete";
            case 18: return "dezoito";
            case 19: return "dezenove";
        }
        return "";
    }

    private String getCentena(String i)
    {
        switch (i)
        {
            case "1": return "cento";
            case "2": return "duzentos";
            case "3": return "trezentos";
            case "4": return "quatrocentos";
            case "5": return "quinhentos";
            case "6": return "seiscentos";
            case "7": return "setecentos";
            case "8": return "oitocentos";
            case "9": return "novecentos";
        }
        return "";
    }

    private String getDezena(String i)
    {
        switch (i)
        {
            case "1": return "dez";
            case "2": return "vinte";
            case "3": return "trinta";
            case "4": return "quarenta";
            case "5": return "cinquenta";
            case "6": return "sessenta";
            case "7": return "setenta";
            case "8": return "oitenta";
            case "9": return "noventa";
        }
        return "";
    }
    private String getUnidade(String i)
    {
        switch (i)
        {
            case "1": return "um";
            case "2": return "dois";
            case "3": return "três";
            case "4": return "quatro";
            case "5": return "cinco";
            case "6": return "seis";
            case "7": return "sete";
            case "8": return "oito";
            case "9": return "nove";
        }
        return "";
    }


}
}
