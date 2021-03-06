# 0001. Naming projects in solution

## Status

Accepted

## Context

Be able to structure different project areas in folders.

## Decision

Root folder for projects is [src]. If solution is developed in multiple programming languages in [src] must be subfolder for language.
If solution is developed in one language subfolder for language is optional.  

## Consequences

What becomes easier or more difficult to do because of this change?

## Examples

### Simple module structure:
* π¦src  
   β£ π[ModuleName].Lib - Common files  
   β£ π[ModuleName].Web - Web API controllers   
   β£ π[ModuleName].WinForms - WinForms frontend  
   β£ π[ModuleName].WebWisej - Wisej frontend  
   β πTests  

### Simple WinForms app structure:
* π¦src  
   β£ π[Application].Lib - Common files  
   β£ π[Application].WinForms    
   β πTests  

### Complex folder structure:
* π¦src  
* β£ πjava  
* β β TBA  
* β πsharp  
**   β£ π[ModuleName..1].Lib - Common files  
**   β£ π[ModuleName..1].Web - Web API controllers   
**   β£ π[ModuleName..1].WinForms - WinForms frontend  
**   β£ π[ModuleName..1].WebWisej - Wisej frontend  
**   β ...  
**   β£ π[ModuleName..N].Lib  
**   β£ π[ModuleName..N].Web  
**   β£ π[ModuleName..N].WinForms  
**   β£ π[ModuleName..N].WebWisej  
**   β ...  
**   β£ π[Application].Lib  
**   β£ π[Application].Web  
**   β£ π[Application].WinForms  
**   β£ π[Application].WebWisej  
**   β ...  
**   β πTests  
