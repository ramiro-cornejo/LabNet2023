import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Supplier } from 'src/app/interfaces/supplier';

@Component({
  selector: 'app-add-edit-supplier',
  templateUrl: './add-edit-supplier.component.html',
  styleUrls: ['./add-edit-supplier.component.css']
})
export class AddEditSupplierComponent {
loading: boolean = false;
form: FormGroup

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      supplierId: ['',Validators.required],
      companyName: ['', Validators.required],
      contactName: ['', Validators.required],
    })
  }

  addSupplier() {
    const supplierId = this.form.value.supplierId;

    const supplier: Supplier = {
      supplierId: this.form.value.supplierId,
      companyName: this.form.value.companyName,
      contactName: this.form.value.contactName,
    }

    console.log(supplier)
  }

}
