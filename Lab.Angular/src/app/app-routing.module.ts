import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactoComponent } from './components/contacto/contacto.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { NosotrosComponent } from './components/nosotros/nosotros.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { ListSuppliersComponent } from './components/list-suppliers/list-suppliers.component';
import { AddEditSupplierComponent } from './components/add-edit-supplier/add-edit-supplier.component';

const routes: Routes = [
  { path: '', redirectTo: '/inicio', pathMatch: 'full'},
  { path: 'inicio', component: InicioComponent },
  { path: 'nosotros', component: NosotrosComponent},
  { path: 'list-suppliers', component: ListSuppliersComponent},
  { path: 'addSupplier', component: AddEditSupplierComponent},
  { path: 'contacto', component: ContactoComponent},
  { path: '**', component: PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
