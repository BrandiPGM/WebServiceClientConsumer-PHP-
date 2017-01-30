<?php  

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
?>
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
                                        <option value="Travers">Travers</option>
                                        <option value="Fleurier">Fleurier</option>
                                        <option value="Noiraigue">Noiraigue</option>
                                    </select>
                                    
                                    <select name="Nb_Jours" form="Localite">
                                        <option value="1">1</option>
                                        <option value="2">2</option>
                                        <option value="3">3</option>
                                        <option value="4">4</option>
                                        <option value="5">5</option>
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
hr {
    height: 30px;
    border-style: solid;
    border-color: black;
    border-width: 1px 0 0 0;
    border-radius: 20px;
}
hr:before { /* Not really supposed to work, but does */
    display: block;
    content: "";
    height: 30px;
    margin-top: -31px;
    border-style: solid;
    border-color: black;
    border-width: 0 0 1px 0;
    border-radius: 20px;
}
</style>
<h1><?php if(isset($_GET['Ville'])){ echo 'Prévision Météo pour'.$Ville;}else {echo $Ville;}?></h1>
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
                                    default : echo 'Aucun jours choisi';
                                        break;
                                }
                            
                            ?>
				
			</table>
		</div>
	</div>
</div>