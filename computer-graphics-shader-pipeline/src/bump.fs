// Set the pixel color using Blinn-Phong shading (e.g., with constant blue and
// gray material color) with a bumpy texture.
// 
// Uniforms:
uniform mat4 view;
uniform mat4 proj;
uniform float animation_seconds;
uniform bool is_moon;
// Inputs:
//                     linearly interpolated from tessellation evaluation shader
//                     output
in vec3 sphere_fs_in;
in vec3 normal_fs_in;
in vec4 pos_fs_in; 
in vec4 view_pos_fs_in; 
// Outputs:
//               rgb color of this pixel
out vec3 color;
// expects: model, blinn_phong, bump_height, bump_position,
// improved_perlin_noise, tangent
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


  float delta = 0.0001;

  // obtain the bump position at local
  vec3 bumpPos = bump_position(is_moon, sphere_fs_in);
  
  // 1. calculate the original u,v direction
  vec3 uhat,vhat;
  tangent(sphere_fs_in, uhat, vhat);

  // 2. transpose origin with du,dv to obtain generated u,v
  // ## height is continuous function defined by perlin noise
  // 3. use the origin with generate u,v; obtain gradient<du,dv>
  // ?? why need to divide delta at last ? tried works even get rid of
  vec3 du = (bump_position(is_moon, sphere_fs_in + delta * uhat) - bumpPos) / delta;
  vec3 dv = (bump_position(is_moon, sphere_fs_in + delta * vhat) - bumpPos) / delta;

  // 4. crossproduct du,dv and obtain the real normal of the bumped surface
  n = normalize(cross(du, dv));
  v = normalize(v_view_pos - tri_view_pos);
  l = normalize(l_view_pos - tri_view_pos);

  // blinn phong color setting
  if(is_moon){
    ka = vec3(0.05,0.05,0.05);
    kd = vec3(0.5,0.5,0.5);
    ks = vec3(0.3,0.3,0.3);
  }
  else{
    ka = vec3(0.05,0.05,0.05);
    kd = vec3(0,0,1);
    ks = vec3(1,1,1);
  }

  color = blinn_phong(ka, kd, ks, p, n, v, l);
  /////////////////////////////////////////////////////////////////////////////
}
