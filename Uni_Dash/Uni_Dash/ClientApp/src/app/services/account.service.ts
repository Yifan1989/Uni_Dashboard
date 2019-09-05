import { Injectable } from '@angular/core';
import { HttpClient } from '../../../node_modules/@angular/common/http';
import { Observable, Subject, BehaviorSubject } from 'rxjs';



@Injectable({
  providedIn: 'root'
})



export class AccountService {

    constructor(private http : HttpClient) { }

    private baseUrlLogin: string = '/api/Login';

    private Loginstatus = new BehaviorSubject<boolean>(this.checkLoginStatus());
    private user = new BehaviorSubject<string>(localStorage.getItem("user"));
    private passwd = new BehaviorSubject<string>(localStorage.getItem("passwd"));


    login(user:string, passwd:string) {

    }


    checkLoginStatus(): boolean
    {
        return false;
    }


}
