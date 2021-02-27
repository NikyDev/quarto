using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturi.Nicolas._4J.giocodicarte.models
{
    class carta
    {
        private int _valore;
        private string _seme;

        public int valore
        {
            get
            {
                return _valore;
            }

            set
            {
                _valore = value;
            }
        }

        public string seme
        {
            get
            {
                return _seme;
            }

            set
            {
                _seme = value;
            }
        }

        public carta(int v, string s)
        {
            valore = v;
            seme = s.ToUpper();
        }

        public string visualizza(carta c)
        {
            if(c.seme=="C")
            {
                if(c.valore==14)
                {
                    return "la tua carta è l'asso di cuori";
                }
                else
                {
                    return "la tua carta è il " + c.valore + " di cuori";
                }
               
            }
            else
            {
                if(c.seme=="Q")
                {
                    if (c.valore == 14)
                    {
                        return "la tua carta è l'asso di quadri";
                    }
                    else
                    {
                        return "la tua carta è il " + c.valore + " di quadri";
                    }
                }
                else
                {
                    if(c.seme=="F")
                    {
                        if (c.valore == 14)
                        {
                            return "la tua carta è l'asso di fiori";
                        }
                        else
                        {
                            return "la tua carta è il " + c.valore + " di fiori";
                        }
                    }
                    else
                    {
                        if(c.seme=="P")
                        {
                            if (c.valore == 14)
                            {
                                return "la tua carta è l'asso di picche";
                            }
                            else
                            {
                                return "la tua carta è il " + c.valore + " di picche";
                            }
                        }
                        else
                        {
                            return "il seme da te inserito non esiste";
                        }
                    }
                }
            }
        }


        public bool vince(carta c1, carta c2)
        {
           
            if(c1.seme==c2.seme)
            {
                if(c1.valore>c2.valore)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(c1.seme=="C")
                {
                    return true;
                }
                else
                {
                    if(c2.seme=="C")
                    {
                        return false;
                    }
                    else
                    {
                        if(c1.seme=="Q")
                        {
                            return true;
                        }
                        else
                        {
                            if(c2.seme=="Q")
                            {
                                return false;
                            }
                            else
                            {
                                if(c1.seme=="F")
                                {
                                    return true;
                                }
                                else
                                {
                                    if(c2.seme=="F")
                                    {
                                        return false;
                                    }
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
