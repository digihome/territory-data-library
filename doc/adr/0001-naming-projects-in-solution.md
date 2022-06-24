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
* 📦src  
   ┣ 📂[ModuleName].Lib - Common files  
   ┣ 📂[ModuleName].Web - Web API controllers   
   ┣ 📂[ModuleName].WinForms - WinForms frontend  
   ┣ 📂[ModuleName].WebWisej - Wisej frontend  
   ┗ 📂Tests  

### Simple WinForms app structure:
* 📦src  
   ┣ 📂[Application].Lib - Common files  
   ┣ 📂[Application].WinForms    
   ┗ 📂Tests  

### Complex folder structure:
* 📦src  
* ┣ 📂java  
* ┃ ┗ TBA  
* ┗ 📂sharp  
**   ┣ 📂[ModuleName..1].Lib - Common files  
**   ┣ 📂[ModuleName..1].Web - Web API controllers   
**   ┣ 📂[ModuleName..1].WinForms - WinForms frontend  
**   ┣ 📂[ModuleName..1].WebWisej - Wisej frontend  
**   ┃ ...  
**   ┣ 📂[ModuleName..N].Lib  
**   ┣ 📂[ModuleName..N].Web  
**   ┣ 📂[ModuleName..N].WinForms  
**   ┣ 📂[ModuleName..N].WebWisej  
**   ┃ ...  
**   ┣ 📂[Application].Lib  
**   ┣ 📂[Application].Web  
**   ┣ 📂[Application].WinForms  
**   ┣ 📂[Application].WebWisej  
**   ┃ ...  
**   ┗ 📂Tests  
