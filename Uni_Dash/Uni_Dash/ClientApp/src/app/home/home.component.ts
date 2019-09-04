import { Component, OnInit } from '@angular/core';
import { Validators, FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit{
  postData = {
      user: "",
      passwd: ""
  }

  url = 'https://localhost:5001/api/login';

  userForm : FormGroup;
  constructor(private fb: FormBuilder, private http: HttpClient) {
    
  }

 
  
  ngOnInit(): void{
    this.userForm = this.fb.group({
      user: [""], //initilize ob not using =
      passwd: [""],
    });
  }

    test() {
        console.log(this.userForm.value);

        this.postData.user = this.userForm.value.user;
        this.postData.passwd = this.userForm.value.passwd;

        this.http.post(this.url, this.postData).toPromise().then(data => {
            console.log(data);
        });
        
    }
}
