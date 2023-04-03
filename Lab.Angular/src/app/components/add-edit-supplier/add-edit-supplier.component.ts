import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Supplier } from 'src/app/interfaces/supplier';
import { SuppliersService } from 'src/app/services/suppliers.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-add-edit-supplier',
  templateUrl: './add-edit-supplier.component.html',
  styleUrls: ['./add-edit-supplier.component.css']
})
export class AddEditSupplierComponent implements OnInit {
loading: boolean = false;
form: FormGroup;
id: number;
operacion: string = 'Agregar';

  constructor(private fb: FormBuilder, private _supplierService: SuppliersService, private _snackBar: MatSnackBar, private router: Router, private aRoute: ActivatedRoute ) {
    this.form = this.fb.group({
      supplierId: ['',Validators.required],
      companyName: ['', Validators.required],
      contactName: ['', Validators.required],
    })
    this.id = Number  (this.aRoute.snapshot.paramMap.get('id'));
  }

  ngOnInit(): void {
    if(this.id != 0){
      this.operacion = 'Editar';
      this.traeSupplier(this.id)
    }
  }

  traeSupplier(id: number){
    this.loading = true;
    this._supplierService.getSupplier(id).subscribe(data =>{
      this.form.patchValue({
        CompanyName: data.companyName,
        ContactName: data.contactName,
      });
      this.loading = false;
    });
  }

  addEditSupplier() {
    const supplier: Supplier = {
      companyName: this.form.value.CompanyName,
      contactName: this.form.value.ContactName,
    }

    if (this.id != 0){
      supplier.supplierId = this.id;
      this.editSupplier(this.id, supplier)
    }else {
      this.agregarSupplier(supplier)
    }
  }

  agregarSupplier(supplier: Supplier){
    this._supplierService.addSupplier(supplier).subscribe(data => {
      this.message('Agregado correctamente')
      this.router.navigate(['/list-suppliers']);
    })
  }

  editSupplier(id: number, supplier: Supplier){
    this.loading = true;
    this._supplierService.updateSupplier(id,supplier).subscribe(() => {
      this.loading = false;
      this.message('Modificación correctamente')
      this.router.navigate(['/list-suppliers']);
    })
  }
  
  message(text: string){
    this._snackBar.open(`Supplier es ${text} correctamente.`, '', {
      duration: 3000,
      horizontalPosition: 'right',
      verticalPosition: 'top'
    });
  }
}
