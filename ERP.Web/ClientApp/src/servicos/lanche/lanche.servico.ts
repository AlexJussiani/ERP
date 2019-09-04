import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Lanche } from "../../app/modelo/lanche";

@Injectable({
  providedIn: "root"
})
export class LancheServico implements OnInit {

  public lanches: Lanche[];

  private _baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.lanches = []; 
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'applicaton/json')
  }

  public cadastrar(lanche: Lanche): Observable<Lanche> {
    return this.http.post<Lanche>(this._baseUrl + "api/lanche/cadastrar", JSON.stringify(lanche), { headers: this.headers });
  }

  public salvar(lanche: Lanche): Observable<Lanche> {

    return this.http.post<Lanche>(this._baseUrl + "api/lanche/salvar", JSON.stringify(lanche), { headers: this.headers });
  }

  public deletar(lanche: Lanche): Observable<Lanche> {

    return this.http.post<Lanche>(this._baseUrl + "api/lanche/deletar", JSON.stringify(lanche), { headers: this.headers });
  }

  public obterTodosIngredientes(): Observable<Lanche[]> {
    return this.http.get<Lanche[]>(this._baseUrl + "api/lanche");
  }

  public obterIngrediente(lancheId: number): Observable<Lanche> {
    return this.http.get<Lanche>(this._baseUrl + "api/lanche/obter");
  }

}
