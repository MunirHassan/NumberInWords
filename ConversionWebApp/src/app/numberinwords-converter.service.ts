import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import "rxjs/Rx";
import { IAccountInfo } from './accountInfo';


@Injectable()
export class ConverterService {
 
  private _postsURL = "http://localhost:2449/api/numberConversion";

  constructor(private http: Http) { }
  convertNumberIntoWords(model: any): Observable<IAccountInfo> {
    return this.http
      .get(this._postsURL + "?name=" + model.name + "&number=" + model.number)
      .map((response: Response) => {
        return <IAccountInfo>response.json();
      })
      .catch(this.handleError);
  }

  private handleError(error: Response) {
    return Observable.throw(error.statusText);
  }
}