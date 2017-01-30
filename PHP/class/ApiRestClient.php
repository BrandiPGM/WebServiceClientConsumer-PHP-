
<?php
/**
 * Simple client class for consuming Apps REST API
 *
 * Pre-requisites:
 * - PHP's curl extension (apt-get install php5-curl)
 *
 * Contributors:
 * - Plinio Sacchetti 
 * 
 * Method: POST, PUT, GET etc
 * Data: array("param" => "value") ==> index.php?param=value
**/
class ApiRestClient
{
    private $hostUrl='http://services.chupa.ch/api/public';
    //private $urlEntity='role';
    private $userAuth = '';
    private $pwdAuth = '';
    //private $version = 'v2';
    //private $userAgent = 'PHP Demo REST Client';

    /*
     * Constructor
     */
    //public function ApiRestClient($host, $version='v1', $user='', $password='', $userAgent='PHP DEMO API Client') {
    public function ApiRestClient($host, $user='', $password='') {
        $this->hostUrl=$host.'/';
        //$urlEntity=$user;
        $this->userAuth = $user;
        $this->pwdAuth = $password;
        //$this->version = $version;
        //$this->userAgent = $userAgent;   
    }
    
    /*
     * Mehtod : GET
     * $url_entity : table corresponding (role, person, classe ou EnseigneA)
     * $data : Data: array("param" => "value") ==> url?param=value
     */
    public function get($url_entity, $data = false)
    {
        $url=$this->hostUrl.$url_entity;
        $curl = curl_init();

        if ($data) {
            $url = sprintf("%s?%s", $url, http_build_query($data));
        }

        $http_message = self::send_request($curl, $url);
        return $http_message;
    }

    /*
     * Mehtod : POST
     * $url_entity : table corresponding (role, person, classe ou EnseigneA)
     * $data : Data: array("param" => "value") ==> url?param=value
     */
    public function post($url_entity, $data = false)
    {
        $url=$this->hostUrl.$url_entity;
        $curl = curl_init();

        if ($data) {
            //curl_setopt($curl, CURLOPT_POSTFIELDS, $data);
        
            $data_json = json_encode($data);
            curl_setopt($curl, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
            curl_setopt($curl, CURLOPT_POST, 1);
            curl_setopt($curl, CURLOPT_POSTFIELDS,$data_json);
        }

        $http_message = self::send_request($curl, $url);
        return $http_message;
    }

     /*
     * Mehtod : PUT
     * $url_entity : table corresponding (role, person, classe ou EnseigneA)
     * $data : Data: array("param" => "value") ==> url?param=value
     */
    public function put($url_entity, $data = false)
    {
        $url=$this->hostUrl.$url_entity;
        $curl = curl_init();

        if ($data) {
            //curl_setopt($curl, CURLOPT_POSTFIELDS, $data);
        
            $data_json = json_encode($data);
            curl_setopt($curl, CURLOPT_HTTPHEADER, array('Content-Type: application/json','Content-Length: ' . strlen($data_json)));
            curl_setopt($curl, CURLOPT_CUSTOMREQUEST, 'PUT');
            curl_setopt($curl, CURLOPT_POSTFIELDS,$data_json);
        }
        $http_message = self::send_request($curl, $url);
        return $http_message;
    }
    
    
     /*
     * Mehtod : DELETE
     * $url_entity : table corresponding (role, person, classe ou EnseigneA)
     * $data : Data: array("param" => "value") ==> url?param=value
     */
    public function delete($url_entity)
    {
        $url=$this->hostUrl.$url_entity;
        $curl = curl_init();

            //curl_setopt($curl, CURLOPT_POSTFIELDS, $data);
        
        curl_setopt($curl, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
        curl_setopt($curl, CURLOPT_CUSTOMREQUEST, 'DELETE');
        $http_message = self::send_request($curl, $url);
        return $http_message;
    }
    
    
    
    /*
     * send the request and return the result
     */
    private function send_request($curl, $url)
    {       
        // Optional Authentication:
        if($this->userAuth!=''){
            curl_setopt($curl, CURLOPT_HTTPAUTH, CURLAUTH_BASIC);
            curl_setopt($curl, CURLOPT_USERPWD, $this->userAuth.':'.$this->pwdAuth);
        }
        curl_setopt($curl, CURLOPT_URL, $url);
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);

        $result = curl_exec($curl);

        curl_close($curl);

        return $result;
    }

}
?>
