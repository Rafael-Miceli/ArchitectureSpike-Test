using System;

namespace ArchitectureSpike.Domain.Interfaces
{    
public interface IAssociateEntitie    
{        
int Id { get; set; }        
string FirstName { get; set; }        
string MiddleName { get; set; }        
string LastName { get; set; }        
DateTime Birth { get; set; }        
string Title { get; set; }    
}
}
