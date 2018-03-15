import { Component, OnInit } from '@angular/core';
import { IAccountInfo } from '../accountInfo';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ConverterService } from '../numberinwords-converter.service';

@Component({
  selector: 'app-numberinwords-converter',
  templateUrl: './numberinwords-converter.component.html',
  styleUrls: ['./numberinwords-converter.component.css']
})

export class NumberInWordsConverterComponent implements OnInit {

  accountInfo: IAccountInfo;
  converterForm: FormGroup;
  isOutputFound: boolean;
  inValidName: boolean;
  inValidNumber: boolean;
  validInput: boolean;

  onSubmit() {

    if (this.converterForm.valid) {

      console.log("Form Submitted!");
      this.isOutputFound = false;
      this.callConverterService();
    }
    else {
      this.validInput = false;
    }

  }

  constructor(private converterService: ConverterService) { }

  ngOnInit() {
    this.validInput = true;

    this.createForm();
  }

  createForm() {
    this.converterForm = new FormGroup({
      fcName: new FormControl('', [
        Validators.required,
        Validators.pattern('[a-zA-Z][a-zA-Z ]+')
      ]),
      fcNumber: new FormControl('', [
        Validators.required,
        Validators.pattern('-?\\d+(\\.\\d{1,2})?')
      ])
    });
  }


  callConverterService(): void {
    this.converterService.convertNumberIntoWords({ name: this.converterForm.controls.fcName.value, number: this.converterForm.controls.fcNumber.value })
      .subscribe(
      result => {
        this.accountInfo = result
        this.isOutputFound = true;
      },
      error => console.log("Error :: " + error)
      )
  }

  onReset() {

    this.inValidName = true;
    this.inValidNumber = true;
    this.isOutputFound = false;
    this.validInput = true;

    this.converterForm.reset();
  }

  isFieldValid(field: string) {
    this.inValidName = (this.converterForm.controls.fcName.valid || !this.converterForm.controls.fcName.touched) && (this.converterForm.controls.fcName.valid || this.validInput);
    this.inValidNumber = (this.converterForm.controls.fcNumber.valid || !this.converterForm.controls.fcNumber.touched) && (this.converterForm.controls.fcNumber.valid || this.validInput);;
    return this.converterForm.get(field).invalid && this.converterForm.get(field).touched;
  }

  displayFieldCss(field: string) {
    return {
      'has-danger': this.isFieldValid(field),
      'has-success': this.isFieldValid(field)
    };
  }
}
