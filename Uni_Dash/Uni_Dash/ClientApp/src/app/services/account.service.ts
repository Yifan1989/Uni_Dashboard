import { Injectable } from '@angular/core';
import { HttpClient } from '../../../node_modules/@angular/common/http';
import { Observable, Subject } from 'rxjs';



@Injectable({
  providedIn: 'root'
})



export class AccountService {

    constructor(private http : HttpClient) { }

    private baseUrlLogin: string = '/api/Login';

    private Loginstatus: Subject<boolean>;
    private user: string;
    private passwd: string;

    login() {

    }
}
