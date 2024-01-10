import 'bootstrap/dist/css/bootstrap.min.css';
import { useEffect, useState } from "react";
import axios from "axios";
import style from '../styles/Home.module.css'

const ClientList2 = () => {
  const [clients, setClients] = useState([]);

  useEffect(() => {
    // Faça uma chamada GET para a API Spring Boot
    axios
      .get("http://apibooki.somee.com/api/Usuarios")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de Categorias:", error);
      });
  }, []);

  return (
    <div>
    
      <h1 className={style.h1}>Lista</h1>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>CPF</th>
            <th>Email</th>
            <th>Telefone</th>
          </tr>
        </thead>
        {clients.map((element) => (
            <tbody key={element.categoriaId}>
              <tr className={style.tabela}>
                <td>{element.id}</td>
                <td>{element.nome}</td>
                <td>{element.cpf}</td>
                <td>{element.email}</td>
                <td>{element.telefone}</td>
              </tr>
            </tbody>
          ))}
      </table>
    </div>
  );
};

export default ClientList2;