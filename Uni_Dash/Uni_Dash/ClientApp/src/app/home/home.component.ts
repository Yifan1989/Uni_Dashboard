import { Component, OnInit } from '@angular/core';
import { Validators, FormGroup, FormControl, FormBuilder } from '@angular/forms';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit{

  userForm : FormGroup;
  constructor(private fb: FormBuilder) { }

  ngOnInit(): void{
    this.userForm = this.fb.group({
      user: [""], //initilize ob not using =
      passwd: [""],
    });
  }

    test() {
        console.log(this.userForm.value);
    }
}
