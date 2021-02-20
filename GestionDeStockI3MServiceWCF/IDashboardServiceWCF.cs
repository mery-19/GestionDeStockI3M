using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace GestionDeStockI3MServiceWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IDashboardServiceWCF" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IDashboardServiceWCF
    {

        [OperationContract]
        int nb_ventes_total();

        [OperationContract]
        int nb_ventes(DateTime date);

        [OperationContract]
        int gain(int id, DateTime d, int id_vente);

        [OperationContract]
        int gain1(int id, int m, int id_vente,int y);//gain mois

        [OperationContract]
        int prix_prod(int id, int quantite);

        [OperationContract]
        int gain_tout(DateTime d);

        [OperationContract]
        int perte(DateTime d);

        [OperationContract]
        List<Vente> findAll();

        [OperationContract]
        List<Vente> findByMounth(int m,int y);

        [OperationContract]
        List<Vente> findByYear(int y);

        [OperationContract]
        List<Vente> findByDay(int d);

        [OperationContract]
        List<Vente> findnow(DateTime d);

        [OperationContract]
        int QuantiteMonth(int m,int y);

        [OperationContract]
        int nb_venteByMonth(int m,int y);

        [OperationContract]
        int gain_month(int m,int y);

        [OperationContract]
        int nb_produit_des(DateTime d);

        [OperationContract]
        int qu(int id, DateTime d);

        [OperationContract]
        int QuantiteYear(int y);

        [OperationContract]
        int nb_venteByYear(int y);

        [OperationContract]
        decimal gain_year(int y);

        [OperationContract]
        decimal perte_year(int y);

        [OperationContract]
        int QuantityWeek(DateTime d, DateTime dd);
        [OperationContract]
        string name_prod(int i);
        [OperationContract]
        int nbr_achat(DateTime d);
        [OperationContract]
        int q_v_m(int id,int m, int y);
        [OperationContract]
        decimal perte_mois(int m,int y);
    }
}
