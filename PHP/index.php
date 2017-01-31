<?php  
if(isset($_GET['VilleAjout']))
{ 
    setcookie($_GET['VilleAjout'], $_GET['VilleAjout'], (time()+ 365*24*3600));
    header("Refresh:0");
}


    if(isset($_GET['Ville'])&&isset($_GET['Nb_Jours']))
    {
        $Nb_Jours = $_GET['Nb_Jours'];
        $Ville = $_GET['Ville'];
        require_once 'class/ApiSimpleGetRestClient.php';
        $client = new ApiSimpleGetRestClient('http://www.prevision-meteo.ch/services/json');
        $response = $client->get($Ville);
        $data = json_decode(($response), True);
    }
    else
    {
        $Nb_Jours = 0;
        $Ville = "Choisissez une ville";
    }
    //var_dump($_COOKIE);
?>
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Web service client consumer</title>

    <meta name="description" content="Source code generated using layoutit.com">
    <meta name="author" content="LayoutIt!">

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">

  </head>
  
<body>
<div class="container-fluid">
	<div class="row">
		<div class="col-md-12">
			<form role="form" action="<?php echo $_SERVER['PHP_SELF'] ?>" method="GET" id="Localite">
				<div class="form-group">
					<label>
						Localité et nombre de jours
					</label>
                                    <select name="Ville" form="Localite">
                                        <option value="Neuchatel">Neuchâtel</option>
                                        <option value="la-Chaux-de-fonds">La Chaux-de-fonds</option>
                                        <option value="Bern">Bern</option>
                                        <option value="Lausanne">Lausanne</option>
                                        <?php 
                                        $Index = 0;
                                        foreach ($_COOKIE as $City)
                                        {
                                            echo '<option value="'.$City.'">'.$City.'</option>';
                                            
                                        }
                                            ?>
                                        
                                    </select>
                                    
                                    <select name="Nb_Jours" form="Localite">
                                        <option value="1">Aujourd'hui</option>
                                        <option value="2">1 jour de plus</option>
                                        <option value="3">2 jours de plus</option>
                                        <option value="4">3 jours de plus</option>
                                        <option value="5">4 jours de plus</option>
                                    </select>
                                    
                                </div>
				<button type="submit" class="btn btn-default">
					Valider
				</button>
			</form>
		</div>   
            <div class="col-md-12">
                
                <hr size=10 align="center" width="100%">
                
            </div>
	</div>
</div>
<style>

</style>
<h1><?php if(isset($_GET['Ville'])){ echo 'Prévision Météo pour '.$Ville;}else {echo $Ville;}?></h1>
<div class="container-fluid">
	<div class="row">
		<div class="col-md-12">
			<table class="table">
                            <?php 
                            echo '<thead> <tr>';
                                switch($Nb_Jours)
                                {
                                    case 1: echo '<th>'.$data['fcst_day_0']['day_long'].'</th></tr></thead>';
                                            echo '<tbody></tr><td><img src='.$data['fcst_day_0']['icon'].'></td></tr>';
                                            echo '<tr><td>Temp. mini : '.$data['fcst_day_0']['tmin'].'°</td></tr>';   
                                            echo '<tr><td>Temp. max : '.$data['fcst_day_0']['tmax'].'°</td></tr></tbody>';
                                        break;
                                    
                                    case 2: echo '<th>'.$data['fcst_day_0']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_1']['day_long'].'</th></tr></thead>';
                                            echo '<tbody></tr><td><img src='.$data['fcst_day_0']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_1']['icon'].'></td></tr>';
                                            echo '<tr><td>Temp. mini : '.$data['fcst_day_0']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_1']['tmin'].'°</td></tr>';
                                            echo '<tr><td>Temp. max : '.$data['fcst_day_0']['tmax'].'°</td>'; 
                                            echo '<td>Temp. max : '.$data['fcst_day_1']['tmax'].'°</td></tr></tbody>';
                                        break;
                                    
                                    case 3: echo '<th>'.$data['fcst_day_0']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_1']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_2']['day_long'].'</th></tr></thead>';
                                            echo '<tbody></tr><td><img src='.$data['fcst_day_0']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_1']['icon'].'></td>';
                                            echo  '<td><img src='.$data['fcst_day_2']['icon'].'></td></tr>';
                                            echo '<tr><td>Temp. mini : '.$data['fcst_day_0']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_1']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_2']['tmin'].'°</td></tr>';
                                            echo '<tr><td>Temp. max : '.$data['fcst_day_0']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_1']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_2']['tmax'].'°</td></tr></tbody>';
                                        break;
                                    
                                    case 4: echo '<th>'.$data['fcst_day_0']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_1']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_2']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_3']['day_long'].'</th></tr></thead>';
                                            echo '<tbody></tr><td><img src='.$data['fcst_day_0']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_1']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_2']['icon'].'></td>';
                                            echo  '<td><img src='.$data['fcst_day_3']['icon'].'></td></tr>';
                                            echo '<tr><td>Temp. mini : '.$data['fcst_day_0']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_1']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_2']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_3']['tmin'].'°</td></tr>';
                                            echo '<tr><td>Temp. max : '.$data['fcst_day_0']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_1']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_2']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_3']['tmax'].'°</td></tr></tbody>';
                                        break;
                                    
                                    case 5: echo '<th>'.$data['fcst_day_0']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_1']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_2']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_3']['day_long'].'</th>';
                                            echo '<th>'.$data['fcst_day_4']['day_long'].'</th></tr></thead>';
                                            echo '<tbody></tr><td><img src='.$data['fcst_day_0']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_1']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_2']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_3']['icon'].'></td>';
                                            echo '<td><img src='.$data['fcst_day_4']['icon'].'></td></tr>';
                                            echo '<tr><td>Temp. mini : '.$data['fcst_day_0']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_1']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_2']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_3']['tmin'].'°</td>';
                                            echo '<td>Temp. mini : '.$data['fcst_day_4']['tmin'].'°</td></tr>';
                                            echo '<tr><td>Temp. max : '.$data['fcst_day_0']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_1']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_2']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_3']['tmax'].'°</td>';
                                            echo '<td>Temp. max : '.$data['fcst_day_4']['tmax'].'°</td></tr></tbody>';
                                        break;
                                    default : echo 'Choisissez le nombre de jour à afficher.';
                                        break;
                                }
                            ?>
				
			</table>
		</div>
	</div>
</div>
<div class="col-md-12">

  <hr size=10 align="center" width="100%">

</div>
<div class="container-fluid">
	<div class="row">
		<div class="col-md-12">
			<form role="form" action="<?php echo $_SERVER['PHP_SELF'] ?>" method="GET" id="Ajout_Localite" >
				<div class="form-group">
					 
					<label for="exampleInputEmail1">
						Ville à ajouter
					</label>
                                    <input type="text" name="VilleAjout" class="form-control" id="Ajout_Localite" />
				</div>
				<button type="submit" class="btn btn-default">
					Ajouter
				</button>
			</form>
		</div>
	</div>
</div>
</body>
</html>