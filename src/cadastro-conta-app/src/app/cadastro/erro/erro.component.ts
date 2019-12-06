import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'cc-erro',
  templateUrl: './erro.component.html',
  styleUrls: ['./erro.component.css']
})
export class ErroComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    console.log("erro");
  }

}
