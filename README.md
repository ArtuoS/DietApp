# Diet+
<h3>Integrantes</h3>
<p>
  <a href="https://github.com/ArtuoS">Arthur Eduardo Molinari</a>, <a href="https://github.com/joanaalice">Joana Alice Kaspareit</a>, <a href="https://github.com/Dudinhaa-luz">Maria Eduarda da Luz</a>, <a href="https://github.com/pablokewitz">Pablo Henrique Kewitz</a> e <a href="https://github.com/thanksrafuh">Rafael Fabiano Campos</a>.
  <br>
  <em>Qualquer outro contributor deste repositório além destes acima é um problema de git.config.</em>
</p>

<p>
  Data para o banco:
  <br>
  <em>
    <b>Obs:</b> Abra o console NuGet dentro do projeto e de um <b>update-database</b> no <b>DataAcessLayer</b> para gerar as tabelas do banco antes de popular.
  </em>
</p>

~~~mysql
Insert into Categories (Name, Status) Values ('Carnes', 1), ('Frutas', 1), ('Hortaliças', 1), ('Leite e derivados', 1), ('Açúcares e Doces', 1),
('Óleos e gorduras', 1), ('Leguminosas', 1),('Pães', 1),('Molhos', 1);

Insert into Foods (CategoryID, Food_Name, Calories, Alcohol, Carbohydrate, Copper, Fiber, Lipid, Magnesium, Phosphor, Potassium, Protein, Sodium, Selenium, Vitamin_A, Vitamin_C, Vitamin_D, Vitamin_E, Vitamin_B6, Vitamin_B12, Zinc, Status, Unit) 
Values 
(1,  'Asa de Frango',  2.22, 0, 0,  0.0001, 0,  0.16,  0.018,  0.132,  0.156,  0.183,  0.1,  0.0001,  0.0001,  0.0007,  0.0001,  0.0003,  0.0003,  0.0001,  0.013, 1,  1),
(1,  'Peito de Frango',  1.72, 0, 0,  0.0001, 0,  0.093,  0.025,  0.174,  0.22,  0.029,  0.1,  0.0001,  0.0001, 0,  0.0001,  0.0003,  0.0005,  0.0001,  0.0008, 1,  1),
(1,  'Presunto',  1.63, 0,  0.038,  0.0001,  0.013,  0.086,  0.022,  0.153,  0.287,  0.166,  0.011,  0.0001, 0,  0.0004,  0.0001,  0.0001,  0.0003,  0.0001,  0.0014, 1,  1),
(1,  'Carne de Porco',  6.32, 0, 0,  0.0001, 0,  0.657,  0.006,  0.084,  0.333,  0.093,  0.1,  0.0001,  0.0001, 0,  0.0001,  0.0004,  0.0001,  0.0001,  0.0006, 1,  1),
(1,  'Salame Italiano',  4.25, 0,  0.012,  0.0002, 0,  0.37,  0.022,  0.229,  0.340,  0.217,  0.019,  0.0001, 0, 0, 0, 0,  0.0006,  0.0001,  0.0042, 1,  1),
(1,  'Picanha',  2.01, 0, 0,  0.0001, 0,  0.127,  0.021,  0.187,  0.315,  0.203,  0.1,  0.0001, 0, 0, 0,  0.0004,  0.0006,  0.0001,  0.0035, 1,  1),
(1,  'Carne bovina moída',  3.32, 0, 0,  0.0001, 0,  0.3,  0.014,  0.132,  0.218,  0.143,  0.1,  0.0001, 0, 0, 0,  0.0005,  0.0003,  0.0001,  0.0036, 1,  1),
(1,  'Filé bovino',  1.86, 0,  0.001,  0.0001, 0,  0.079,  0.025,  0.245,  0.363,  0.288,  0.003,  0.0001, 0, 0, 0, 0,  0.0005,  0.0001, 0, 1,  1),
(2,  'Maçã',  0.52, 0,  0.13,  0.0001,  0.002,  0.002,  0.0005,  0.0011,  0.107,  0.003,  0.001, 0,  0.0046, 0,  0.0002,  0.0002,  0.0001, 0,  0.0001, 1,  1),
(2,  'Damasco',  0.17, 0,  0.001,  0.0001,  0.002,  0.004,  0.0010,  0.023,  0.259,  0.001,  0.001,  0.0001, 0,  0.010, 0,  0.0009,  0.0001, 0,  0.0002, 1,  1),
(2,  'Banana',  0.89, 0,  0.22,  0.0001,  0.003,  0.0027,  0.0022,  0.358,  0.011,  0.001,  0.0001, 0,  0.0087, 0,  0.0001,  0.0004, 0,  0.0001, 0, 1,  1),
(2,  'Amora',  0.43, 0,  0.96,  0.0002,  0.053,  0.005,  0.020,  0.022,  0.162,  0.14,  0.001,  0.0001, 0,  0.0021, 0,  0.0012,  0.0001, 0,  0.0005, 1,  1),
(2,  'Mirtilo',  0.57, 0,  0.14,  0.0001,  0.024,  0.003,  0.006,  0.0012,  0.077,  0.007,  0.0001, 0,  0.0097, 0,  0.0006,  0.0001, 0,  0.0002, 0, 1,  1),
(2,  'Cereja',  0.63, 0,  0.16,  0.0001,  0.021,  0.002,  0.011,  0.021,  0.222,  0.001, 0, 0, 0,  0.0007, 0,  0.0001,  0.0001, 0,  0.0001, 1,  1),
 (2,  'Figo',  0.74, 0,  0.19,  0.0001,  0.029,  0.003,  0.017,  0.014,  0.232,  0.008,  0.001,  0.0001, 0,  0.0002, 0,  0.0001,  0.0001, 0,  0.001, 1,  1),
(2,  'Chuchu',  0.19, 0,  0.004,  0.0001,  0.017,  0.001,  0.012,  0.018,  0.125,  0.008,  0.001,  0.0001, 0,  0.077, 0,  0.0001,  0.0001, 0,  0.0007, 1,  1),
(2,  'Manga',  0.60, 0,  0.15,  0.0001,  0.016,  0.004,  0.010,  0.014,  0.168,  0.008,  0.001,  0.0001, 0,  0.036, 0,  0.0009,  0.0001,  0.0001,  0.0001, 1,  1),
 (2,  'Melancia',  0.30, 0,  0.075,  0.0001,  0.004,  0.001,  0.010,  0.011,  0.112,  0.004,  0.001,  0.0001, 0,  0.0081, 0,  0.0001,  0.0001, 0,  0.0001, 1,  1),
(3,  'Ervilha',  0.44, 0,  0.95,  0.0001,  0.33,  0.03,  0.058,  0.065,  0.215,  0.33,  0.01,  0.0001, 0,  0.033, 0,  0.0005,  0.0002, 0,  0.0003, 1,  1),
(3,  'Vagem',  0.31, 0, 7, 0, 1,  0.02,  0.002,  0.025,  0.038,  0.21,  0.18,  0.001,  0.0001, 0,  0.012,  0.0004,  0.0001, 0,  0.0002, 1,  1),
(3,  'Brócolis' , 0.34, 0,  0.06,  0.0001,  0.02,  0.004,  0.021,  0.066,  0.31,  0.28,  0.001,  0.0001, 0,  0.089, 0,  0.0008,  0.0002, 0,  0.0004, 1,  1),
(3,  'Aipim',  1.6, 0,  0.0001,  0.18,  0.003,  0.021,  0.027,  0.27,  0.14,  0.001,  0.0001, 0,  0.02, 0,  0.0002,  0.0001, 0,  0.0003, 0, 1,  1),
(3,  'Alface Verde',  0.15, 0,  0.29,  0.0001, 0.1,  0.001, 0.13, 0.29,  0.194,  0.014,  0.001,  0.0001, 0,  0.009, 0,  0.0002,  0.0001,  0.0002, 0, 1,  1),
(3,  'Tomate',  0.16, 0,  0.032,  0.0001,  0.009,  0.002,  0.008,  0.029,  0.212,  0.012,  0.0001,  0.0001, 0,  0.016, 0, 0,  0.0001, 0,  0.0001, 1,  1),
(3,  'Pepino',  0.15, 0, 0.36,  0.0001,  0.005,  0.001,  0.013,  0.024,  0.147,  0.007,  0.001,  0.0001, 0,  0.0028, 0,  0.0001,  0.0001, 0,  0.0002, 1,  1),
(3,  'Milho',  3.65, 0,  0.743,  0.0003,  0.073,  0.047,  0.127,  0.21,  0.287, 0.94,  0.001,  0.0001, 0, 0, 0,  0.0005,  0.0006, 0,  0.022, 1,  1),
(3,  'Azeitona',  1.15, 0,  0.063,  0.0003,  0.032,  1.07,  0.004,  0.003,  0.008,  0.008,  0.007,  0.0001, 0,  0.0009, 0,  0.0017,  0.0001, 0,  0.0002, 1,  1),
(4,  'Leite',  0.61, 0,  0.048,  0.0001, 0,  0.033,  0.010,  0.0084,  0.132,  0.033,  0.001,  0.0001,  0.0001, 0,  0.0001,  0.0001,  0.0001,  0.0001,  0.0004, 1,  3),
(4,  'Iogurte Light',  0.63, 0,  0.007,  0.0001, 0,  0.001,  0.0017,  0.144,  0.234,  0.053,  0.001,  0.0001,  0.0001,  0.0008, 0,  0.0001,  0.0001,  0.0001,  0.0009, 1,  3),
(4,  'Iogurte',  0.61, 0,  0.047,  0.0001, 0,  0.003,  0.012,  0.095,  0.155,  0.035,  0.001,  0.0001,  0.0001,  0.0005,  0.0001,  0.0001,  0.0001,  0.0001,  0.0006, 1,  3),
(4,  'Leite Light',  0.34, 0,  0.005,  0.0001, 0.9, 0,  0.0011,  0.101,  0.156,  0.034,  0.001,  0.0001,  0.0001, 0,  0.0001,  0.0001,  0.0001,  0.0001, 0, 1,  3),
(4,  'Queijo Parmesão',  0.392, 0,  0.032,  0.0001, 0,  0.25,  0.0045,  0.694,  0.092 , 0.35,  0.016,  0.0001,  0.0002, 0,  0.0001,  0.0002,  0.0001,  0.0001,  0.0028 , 1,  1),
(4,  'Requeijão' , 0.34, 0,  0.041, 0,  0.34,  0.009,  0.106,  0.138,  0.059,  0.003,  0.0001,  0.0004, 0,  0.0001,  0.0003,  0.0001,  0.0001,  0.0005, 0, 1,  1),
(5,  'Chocolate meio-amargo',  4.8, 0,  0.63,  0.0007,  0.059,  0.3,  0.115,  0.132,  0.365,  0.042,  0.001,  0.0001, 0, 0, 0,  0.0003,  0.0001, 0,  0.0016, 1,  1),
(5,  'Chocolate Branco',  5.39, 0,  0.59,  0.0001,  0.002,  0.32,  0.012,  0.176,  0.286,  0.059,  0.001,  0.0001,  0.0001,  0.0005, 0,  0.001,  0.0001,  0.0001,  0.0007, 1,  1),
(5,  'Chocolate ao Leite',  5.35, 0,  0.59,  0.0005,  0.0034,  0.297,  0.063,  0.208,  0.372,  0.076,  0.001,  0.0001,  0.0001, 0, 0,  0.0005,  0.0001,  0.0001,  0.0023, 1,  1),
(5,  'Cookie com gotas de chocolate',  4.74, 0,  0.63,  0.0003,  0.002,  0.23,  0.039,  0.084,  0.147,  0.05,  0.003,  0.0001, 0, 0, 0,  0.0022,  0.0001,  0.0001,  0.0007, 1,  1),
(6,  'Óleo de Abacate',  8.84, 0, 0, 0, 0,  0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,  3),
(6,  'Óleo de Côco',  8.62, 0, 0, 0, 0,  0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0,  0.0001, 0, 0, 0, 1,  3),
(6,  'Azeite de Oliva',  8.84, 0, 0, 0, 0,  0.1, 0, 0,  0.001, 0,  0.001, 0, 0, 0, 0,  0.0143, 0, 0, 0, 1,  3),
(6,  'Banha',  9.02, 0, 0, 0, 0, 0,  0.1, 0, 0, 0, 0, 0,  0.0001, 0, 0,  0.0001,  0.0006, 0,  0.0001, 1,  1),
(6,  'Margarina',  7.17, 0,  0.007, 0, 0,  0.807,  0.003,  0.005,  0.018,  0.002,  0.001, 0,  0.0008,  0.0002, 0,  0.009,  0.0001,  0.0001, 0, 1,  1),
(7,  'Feijão Branco',  3.37, 0,  0.608,  0.0008,  0.244,  0.015,  0.175,  0.407, 1185,  0.223,  0.001,  0.0001, 0, 0, 0,  0.0001,  0.0004, 0,  0.0036, 1,  1),
(7,  'Feijão Carioca',  3.47, 0,  0.625,  0.0009,  0.244,  0.155,  0.012,  0.176,  0.411, 1393,  0.214,  0.001,  0.0001, 0,  0.0063, 0,  0.0002,  0.0005,  0.0023, 1,  3),
(7,  'Feijão Preto',  3.41, 0,  0.624,  0.0008,  0.155,  0.014,  0.171,  0.352, 1483,  0.216,  0.001,  0.0001, 0, 0, 0,  0.0002,  0.0003, 0,  0.0036, 1,  1),
(7,  'Grão de Bico',  3.64, 0,  0.607,  0.0008,  0.174,  0.06,  0.115,  0.366,  0.875,  0.193,  0.001,  0.0001, 0,  0.004, 0,  0.0016,  0.0011, 0,  0.0069, 1,  1),
(7,  'Lentilha',  3.53, 0,  0.601,  0.0005,  0.305,  0.011,  0.122,  0.451,  0.955,  0.258,  0.001,  0.0001, 0,  0.0044, 0,  0.0005,  0.0005, 0,  0.0048, 1,  1),
(8,  'Pão Francês', 2.89, 0, 0.56, 0.0001, 0.024, 0.018, 0.028, 0.114, 0.128, 0.118, 0.005, 0.0001, 0, 0.0002, 0, 0.0002, 0.0001, 0, 0.0009, 1, 1),
(8,  'Pão Integral', 2.78, 0, 0.514, 0.0003, 0.06, 0.054, 0.081, 0.187, 0.314, 0.084, 0.003, 0.0001, 0, 0, 0, 0.0008, 0.0002, 0, 0.0015, 1, 1),
(6,  'Óleo de Soja', 8.84, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0008, 0, 0, 0, 1, 1),
(3,  'Batata', 0.87, 0, 0.2,  0.0002, 0.002, 0.001, 0.022, 0.044, 0.379, 0.019, 0.002, 0.0001, 0, 0.013, 0, 0.0001, 0.0003, 0, 0.0003, 1, 1),
(4,  'Cream Cheese', 3.42, 0, 0.041, 0.0001, 0, 0.34, 0.009, 0.106, 0.138, 0.059, 0.003, 0.0001, 0.0004, 0, 0.0001, 0.0003, 0.0001, 0.0001, 0.0005, 1, 1),
(1,  'Filé de Peixe', 1, 0, 0, 0.0001, 0.005, 0.035, 0.024, 0.171, 0.003, 0.175, 0.002, 0.0001, 0.0001, 0, 0, 0, 0.0001, 0.0001, 0.0004, 1, 1),
(3,  'Alho', 1.49, 0, 0.33, 0.0003, 0.02, 0.005, 0.025, 0.153, 0.401, 0.064, 0.001, 0.0001, 0, 0.031, 0, 0.0001, 0.0012, 0, 0.0012, 1, 1),
(9,  'Molho Pesto', 6.75, 0, 0.025, 0, 0.01, 0.7, 0, 0, 0, 0.05, 0.004, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1),
(3,  'Abóbrinha', 0.15, 0, 0.027, 0.0001, 0.01, 0.004, 0.019, 0.037, 0.264, 0.011, 0.002, 0.0001, 0, 0.012, 0, 0.0001, 0.0001, 0, 0.0003, 1, 1),
(6,  'Manteiga', 7.17, 0, 0.0001, 0, 0, 0.81, 0.002, 0.024, 0.024, 0.009, 0.007, 0.0001, 0.0007, 0, 0.0001, 0.002, 0.0001, 0.0001, 0.0001, 1, 1),
(6,  'Ovo', 0.134, 0, 0.007, 0.0001, 0, 0.95, 0.0012, 0.198, 0.138, 0.12, 0.001, 0.0001, 0.0002, 0, 0.0001, 0.011, 0.0002, 0.0001, 0.013, 1, 1),
(3,  'Farinha de trigo', 0.364, 0, 0.76, 0.0001, 0.027, 0.01, 0.022, 0.108, 0.107, 0.10, 0.001, 0.0001, 0, 0, 0, 0.0001, 0.0001, 0, 0.0007, 1, 1),
(5,  'Açucar', 0.387, 0, 0.99, 0.0001, 0, 0, 0, 0, 0.002, 0, 0.001, 0.0001, 0, 0, 0, 0, 0, 0, 0.0001, 1, 1),
(8,  'Fermento em pó', 0.53, 0, 0.22, 0.0001, 0.0002, 0, 0.027, 2.191, 0.020, 0, 0.10, 0.0001, 0, 0, 0, 0, 0, 0, 0.0001, 1, 1),
(5,  'Mel', 0.304, 0, 0.82, 0.0001, 0.0002, 0, 0.020, 0.0004, 0.052, 0.003, 0.001, 0.0001, 0, 0, 0, 0, 0.0001, 0, 0.0002, 1, 1),
(7,  'Arroz' , 1.3, 0, 0.28, 0.0001, 0.004, 0.003, 0.012, 0.043, 0.035, 0.027, 0.001, 0.0001, 0, 0, 0, 0.0001, 0.0001, 0, 0.005, 1, 1),
(7,  'Macarrão', 1.58, 0, 0.30, 0.0001, 0.018, 0.009, 0.018, 0.058, 0.044, 0.058, 0.001, 0.0001, 0, 0, 0, 0.0001, 0.0001, 0, 0.0005, 1, 1),
(3,  'Cenoura', 0.41, 0, 0.96, 0.0001, 0.28, 0.002, 0.012, 0.035, 0.320, 0.009, 0.001, 0.0001, 0, 0.0059, 0, 0.0007, 0.0001, 0, 0.0002, 1, 1),
(3,  'Cebola' , 0.42, 0, 0.096, 0.0001, 0.014, 0.002, 0.011, 0.035, 0.166, 0.014, 0.002, 0.0001, 0, 0.0052, 0, 0.0001, 0.0001, 0, 0.0002, 1, 1),
(9,   'Molho de Tomate', 0.29, 0, 0.067, 0.0001, 0.015, 0.002, 0.016, 0.026, 0.331, 0.013, 0.001, 0.0001, 0, 0.007, 0, 0.0014, 0.0001, 0, 0.0002, 1, 1),
(2,  'Morango', 0.32, 0, 0.077, 0.0001, 0.02, 0.03, 0.013, 0.024, 0.153, 0.007, 0.0001, 0.0001, 0, 0.0588, 0, 0.0003, 0.0001, 0, 0.0001, 1, 1),
(2,  'Kiwi', 0.61, 0, 0.147, 0.0001, 0.003, 0.005, 0.017, 0.034, 0.312, 0.011, 0.001, 0.0001, 0, 0.092, 0, 0.0015, 0.0001, 0, 0.0001, 1, 1);

Insert into Meals (Name, Category, Description, Image, Status, Total_Calories, Total_Carbohydrates, Total_Proteins, Total_Lipids) Values
( 'Pão com Requeijão', 0,  '1 Pão francês e 1 colher de sopa de requeijão','Microsoft.AspNetCore.Http.FormFile',0,395.63,28.59,6.03,0.94),
( 'Lasanha de Abóbrinha (1 porção 200g)' , 1,  ' 1 abobrinha italiana grande, 2 tomates médios,  1/2 xícara de cream cheese, Molho pesto a gosto, Sal e pimenta do reino (opcional) a gosto','Microsoft.AspNetCore.Http.FormFile', 1,123.56,1358,1.45,12679),
( 'Vitamina de Frutas (1 porção 600g)', 0,  '1/2 Maçã, 500ml leite, 1 banana', 'Microsoft.AspNetCore.Http.FormFile', 1,485.82,68.33,16.92,17087),
( 'Sanduiche de Presunto e Queijo', 0,  '1 Pão fracês, 1 fatia de presunto, 1 fatia de queijo parmesão', 'Microsoft.AspNetCore.Http.FormFile', 1,203.18,28.08,22.83,15.03),
( 'Iogurte com Damasco (1 porção 600g)', 0,  'Damasco 100g, Iogurte light 500g','Microsoft.AspNetCore.Http.FormFile', 1,332,3.6,26.6,0.9),
( 'Panqueca com Mirtilo (2 porção 200g)', 0,  '1 colher (chá) de sal,1 xícara de leite,2 ovos,2 xícaras de farinha de trigo,2 colheres (chá) de óleo ,4 colheres (sopa) de açúcar,4 colheres (chá) de fermento em pó, 100g de mirtilo, 2 colheres (chá) de mel','Microsoft.AspNetCore.Http.FormFile', 1,610.85,359.9,51.31,98.16),
( 'Sanduiche de Presunto e Queijo', 2,  '1 Pão fracês, 1 fatia de presunto, 1 fatia de queijo parmesão','Microsoft.AspNetCore.Http.FormFile', 1,203.18,28.08,22.83,15.03),
( 'Panqueca com Mirtilo (2 porção 200g)', 2,  '1 colher (chá) de sal, 1 xícara de leite, 2 ovos, 2 xícaras de farinha de trigo, 2 colheres (chá) de óleo, 4 colheres (sopa) de açúcar, 4 colheres (chá) de fermento em pó, 100g de mirtilo, 2 colheres (chá) de mel','Microsoft.AspNetCore.Http.FormFile', 1,610.85,356.99,51.30,98.16),
( 'Lasanha de Abóbrinha (2 porção de 200g)' , 2,  'Ingredientes: 1 abobrinha italiana grande, 2 tomates médios, 1/2 xícara de cream cheese, Molho pesto a gosto, Sal e pimenta do reino (opcional) a gosto','Microsoft.AspNetCore.Http.FormFile', 1,247.12,2716,2.9,6335),
( 'Vitamina de Frutas (1 porção 600g)', 2,  '1/2 Maçã, 500ml leite, 1 banana','Microsoft.AspNetCore.Http.FormFile',1,485.82,68.33,16.92,17.08),
( 'Salada de Tomate, Alface e Brócolis', 2,  '1 Tomate, 2 folhas de alface verde, 2 brócolis(talo e flores)','Microsoft.AspNetCore.Http.FormFile',1,25.88,9.16,7.86,0.304),
( 'Peito de Frango Grelhado (1 porção 200g) + Salada de Tomate, alface e Brócolis', 1,  'Tempere o frango ao seu gosto, aqueça uma frigideira com cerca de meia colher de azeite para cada peito de frango(100g), deixe os frangos até dourar de ambos os lados,  1 Tomate, 2 folhas de alface verde, 2 brócolis(talo e flores)','Microsoft.AspNetCore.Http.FormFile', 1,259.26,9.16,10.48,10604),
( 'Peito de Frango Grelhado (1 porção 200g) + Salada de Tomate, alface e Brócolis + Purê de Batata', 1,  'Tempere o frango ao seu gosto, aqueça uma frigideira com cerca de meia colher de azeite para cada peito de frango(100g), deixe os frangos até dourar de ambos os lados,  1 Tomate, 2 folhas de alface verde, 2 brócolis(talo e flores), 200g de batata, 1/4 xícara de leite, 1 colheres (sopa) de margarina, sal a gosto, 1 dente de alho espremido','Microsoft.AspNetCore.Http.FormFile',1,553.51,52.16,16.16,23.58),
( 'Filé de Peixe Grelhado + Salada de Tomate, Alface e Brócolis', 1,  '2 filés de peixe, 1 dente de alho, Suco de meio limão, 2 colheres (sopa) de manteiga, sal e pimenta do reino a gosto, Alecrim picado a gosto + 1 Tomate, 2 folhas de alface verde, 2 brócolis (talo e flores)','Microsoft.AspNetCore.Http.FormFile', 1,253.93,10165,28207,16664),
( 'Filé de Peixe Grelhado + Salada de Tomate, Alface e Brócolis + Purê de Batata', 1,  '2 filés de peixe, 1 dente de alho, Suco de meio limão, 2 colheres (sopa) de manteiga, sal e pimenta do reino a gosto, Alecrim picado a gosto + 1 Tomate, 2 folhas de alface verde, 2 brócolis (talo e flores), 200g de batata, 1/4 xícara de leite, 1 colheres (sopa) de margarina, sal a gosto, 1 dente de alho espremido)','Microsoft.AspNetCore.Http.FormFile', 1,548.18,53165,32887,29644),
( 'Macarrão, Carne Moída e Salada de Cenoura Brócolis e Alface', 1,  '1/2 Cenoura, 3 Brócolis (talo e flores), 2 folhas de alface,  140g de macarrão (1 porção), 62,5g de Carne Moída, 1/4 de Cebola,  1/2 colher de sopa de óleo, 1 dente de alho, 1 colher de sopa de extrato de tomate, coentro a gosto','Microsoft.AspNetCore.Http.FormFile', 1,1041.037,168.168,28.33,80.5),
( 'Arroz, Carne Moída e Salada de Cenoura Brócolis e Alface', 1,  '1/2 Cenoura, 3 Brócolis (talo e flores), 2 folhas de alface,  50g de arroz (1 porção), 62,5g de Carne Moída, 1/4 de Cebola,  1/2 colher de sopa de óleo, 1 dente de alho, 1 colher de sopa de extrato de tomate, coentro a gosto','Microsoft.AspNetCore.Http.FormFile', 1,884.84,140.16,21.55,79.38),
( 'Ensopado de Carne Moída, Purê de Batata, Salada de Tomate, Alface e Pepino', 1,  '62,5g de Carne Moída, 1/4 de Cebola,  1/2 colher de sopa de óleo, 1 dente de alho, 1 colher de sopa de extrato de tomate, coentro a gosto, 200g de batata, 1/4 xícara de leite, 1 colheres (sopa) de margarina, sal a gosto, 1 dente de alho espremido, 2 Tomate, 2 folhas de Alface, 1/2 pepino japones','Microsoft.AspNetCore.Http.FormFile',1,1115.62,144.77,17.79,92.47),
( 'Filé de Frango Grelhado, Batata Sauté, Salada de Tomate, Cenoura e Alface', 1,  '1 Filé de Frango (50g), 1/2 colher de óleo de soja, 200g de batata, 1 colher de manteiga, 1 colher de salsinha picada, 1 Tomate, 1/2 Cenoura, 2 folhas de alface' ,'Microsoft.AspNetCore.Http.FormFile', 1,992.99,163.33,9.44,82.13),
( 'Salada de Fruta', 0,  '1/2 Maça, 1 Banana, 3 Morangos, 1 Kiwi, 1/2 Manga','Microsoft.AspNetCore.Http.FormFile', 1,233.49,57.59,2.149,25.874),
( 'Salada de Fruta', 2,  '1/2 Maça, 1 Banana, 3 Morangos, 1 Kiwi, 1/2 Manga','Microsoft.AspNetCore.Http.FormFile', 1,233.49,57.59,2.149,25.874);


Insert into FoodAmountPerMeal (FoodID, Quantity, MealID) Values
(48, 50, 1),
(33, 14.5, 1),
(56, 4.75, 2),
(24, 44363, 2),
(52, 44325, 2),
(55, 13, 2),
(9, 91.0, 3),
(28, 500, 3),
(11, 150, 3),
(49, 50, 4),
(3, 30, 4),
(32, 39, 4),
(10, 100, 5),
(29, 500, 5),
(28, 240, 6),
(58, 44, 6),
(40, 27, 6),
(13, 100, 6),
(58, 44, 6),
(59, 324, 6),
(60, 40, 6),
(61, 20, 6),
(62, 43, 6),
(49, 50, 7),
(3, 30, 7),
(32, 39, 7),
(28, 240, 8),
(58, 44, 8),
(40, 27, 8),
(13, 100, 8),
(58, 44, 8),
(59, 324, 8),
(60, 40, 8),
(61, 20, 8),
(62, 43, 8),
(56, 4.75, 9),
(24, 16.6, 9),
(52, 9.5, 9),
(55, 13, 9),
(9, 91.0, 10),
(28, 500, 10),
(11, 150, 10),
(24, 100, 11),
(23, 16, 11),
(21, 22, 11),
(24, 100, 12),
(23, 16, 12),
(21, 22, 12),
(2, 100, 12),
(50, 7, 12),
(24, 100, 13),
(23, 16, 13),
(21, 22, 13),
(2, 100, 13),
(50, 7, 13),
(51, 200, 13),
(28, 20, 13),
(42, 15, 13),
(54, 3, 13),
(24, 100, 14),
(23, 16, 14),
(21, 22, 14),
(53, 116, 14),
(54, 3, 14),
(57, 15, 14),
(24, 100, 15),
(23, 16, 15),
(21, 22, 15),
(53, 116, 15),
(54, 3, 15),
(57, 15, 15),
(51, 200, 15),
(28, 20, 15),
(42, 15, 15),
(54, 3, 15),
(65, 120, 16),
(23, 16, 16),
(21, 33, 16),
(64, 140, 16),
(7, 62.5, 16),
(66, 25, 16),
(50, 60, 16),
(54, 3, 16),
(67, 14.3, 16),
(65, 120, 17),
(23, 16, 17),
(21, 33, 17),
(63, 50, 17),
(7, 62.5, 17),
(66, 25, 17),
(50, 60, 17),
(54, 3, 17),
(67, 14.3, 17),
(24, 109, 18),
(23, 16, 18),
(25, 250, 18),
(7, 62.5, 18),
(66, 25, 18),
(50, 60, 18),
(54, 3, 18),
(67, 14.3, 18),
(51, 200, 18),
(28, 25, 18),
(42, 15, 18),
(54, 3, 18),
(24, 109, 19),
(65, 120, 19),
(23, 16, 19),
(2, 100, 19),
(50, 60, 19),
(51, 200, 19),
(57, 15, 19),
(9, 50, 20),
(11, 100, 20),
(68, 36, 20),
(69, 77, 20),
(17, 100, 20),
(9, 50, 21),
(11, 100, 21),
(68, 36, 21),
(69, 77, 21),
(17, 100, 21);
~~~