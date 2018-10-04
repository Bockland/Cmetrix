public static void Link(IOrganizationService Service)
{
    string EntityPrincipal = "";
    string EntitySecundario = "";
    string Relationship = "";
    QueryExpression Consulta = new QueryExpression();
    Consulta.EntityName = EntityPrincipal;
    Consulta.ColumnSet = new ColumnSet(true);
    Consulta.Criteria.AddCondition(new ConditionExpression("statuscode", ConditionOperator.Equal, 0));
    LinkEntity L1 = new LinkEntity(Relationship, EntitySecundario, "atributolink1", "atributolink1", JoinOperator.Inner);
    L1.Columns = new ColumnSet(true);
    L1.LinkCriteria.AddCondition(new ConditionExpression("statuscode", ConditionOperator.Equal, 0));
    LinkEntity L2 = new LinkEntity("Relacion", "Entity3", "atributolink", "atributolink", JoinOperator.Inner);
    L2.Columns = new ColumnSet(true);
    L2.LinkCriteria.AddCondition(new ConditionExpression("statuscode", ConditionOperator.Equal, 0));
    L1.LinkEntities.Add(L2);
    Consulta.LinkEntities.Add(L1);
    EntityCollection Resultado = Service.RetrieveMultiple(Consulta);
	javier wet
}