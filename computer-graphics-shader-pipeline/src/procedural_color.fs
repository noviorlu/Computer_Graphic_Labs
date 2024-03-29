// Set the pixel color to an interesting procedural color generated by mixing
// and filtering Perlin noise of different frequencies.
//
// Uniforms:
uniform mat4 view;
uniform mat4 proj;
uniform float animation_seconds;
uniform bool is_moon;
// Inputs:
in vec3 sphere_fs_in;
in vec3 normal_fs_in;
in vec4 pos_fs_in; 
in vec4 view_pos_fs_in; 
// Outputs:
out vec3 color;

// expects: blinn_phong, perlin_noise
void main()
{
  /////////////////////////////////////////////////////////////////////////////
  // Replace with your code 
  vec3 ka, kd, ks, n, v, l;
  float p = 200;

  vec3 v_view_pos = vec3(0,0,0);

  // define light in world then transfer to view
  float periodLight = 9;
  float thetaLight = 2*M_PI*animation_seconds / periodLight;

  vec4 lightPos = vec4(5*sin(thetaLight), 2, -5*cos(thetaLight), 1);
  vec3 l_view_pos = (view * lightPos).xyz;

  vec3 tri_view_pos = (view_pos_fs_in.xyz);

  n = normal_fs_in;
  v = normalize(v_view_pos - tri_view_pos);
  l = normalize(l_view_pos - tri_view_pos);

  if(is_moon){
    ka = vec3(0.05,0.05,0.05);
    kd = vec3(0.5,0.5,0.5);
    ks = vec3(1,1,1);
  }
  else{
    ka = vec3(0.05,0.05,0.05);
    kd = vec3(0,0,1);
    ks = vec3(1,1,1);
  }
  
  float noise = perlin_noise(9*tri_view_pos);
  color = blinn_phong(ka, kd * noise, ks, p, n, v, l);
  /////////////////////////////////////////////////////////////////////////////
}
