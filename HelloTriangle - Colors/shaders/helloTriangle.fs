#version 400

uniform vec4 inputColor;
out vec4 color;

in vec2 texcoord;
uniform sampler2D texbuffer;

uniform vec2 offsets;

void main()
{
	color = texture(texbuffer,texcoord + offsets);
	float media = color.r * 0.333 + color.g * 0.333 + color.b * 0.333;
	color = vec4(media,media,media,color.a);
}