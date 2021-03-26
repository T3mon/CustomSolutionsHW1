import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { PrivateData } from './PrivateData';

@Component({
  selector: 'app-private-data',
  templateUrl: './private-data.component.html',
  styleUrls: ['./private-data.component.css']
})
export class PrivateDataComponent implements OnInit {

  public privateDataset: Array<PrivateData>;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Array<PrivateData>>(baseUrl + 'privatedata/get-privatedata').subscribe(
      result => {
        this.privateDataset = result;
      },
      error => {
        console.log("privateData error: " + error);
      }
    );

  }

  ngOnInit() {
  }

}
