#version 330 core
in vec2 oTexPos;

uniform sampler2D texture1;
uniform sampler2D texture2;

out vec4 FragColor;
void main(){
    FragColor = mix(texture(texture1, oTexPos), texture(texture2, oTexPos), 0.2);
}
