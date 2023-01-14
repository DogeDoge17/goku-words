from PIL import Image
from numpy import char
import requests;
from bs4 import BeautifulSoup 
import urllib3
import urllib.request
from PIL import Image, ImageDraw, ImageFont
import random
import textwrap

imgUrls = [""];

http = urllib3.PoolManager()

prefix = ""
character = "Goku"

f = open("words.txt", "r", encoding="utf-8")
fileContent = f.read()
f.close()

fileLi = fileContent.split(":")

prefix = fileLi[0]
character = fileLi[1]
msgTop = fileLi[2]
msgBottom = fileLi[3]



prefixesFriendly = []
charactersFriendly = []

prefixesFriendly.append(prefix.replace("+", " "));
charactersFriendly.append(character.replace("+", " "));

url ='https://www.google.com/search?q=' + prefix + character + '&source=lnms&tbm=isch&sa=X&ved=2ahUKEwi19ZOm9bj6AhWJkokEHedCDVAQ_AUoAXoECAIQAw&biw=1920&bih=919&dpr=1'

#msg = "Hey it's me " + charactersFriendly 
#msgBottom = "I AM "+ charactersFriendly 


response = http.request('GET', url)
soup = BeautifulSoup(response.data)

images = soup.findAll('img')
for image in images:
    #print(image)  
    #if engine[chooseUrl] == "Bing":
     #   if image.has_attr("class"):
      #      if image['class'] == "mimg":
       #         if image.has_attr('src'):
        #        # print(image['src'])
         #           imgUrls.append(image['src']);
          #      elif image.has_attr('src2'):
           #         # print(image['src2'])
            #        imgUrls.append(image['src2']);
    #else:
        if image.has_attr('src'):
            # print(image['src'])
            imgUrls.append(image['src']);
        elif image.has_attr('src2'):
            # print(image['src2'])
            imgUrls.append(image['src2']);


f = open("output.html", "w", encoding="utf-8")
f.write(soup.text)
f.close()


for ur in imgUrls: 
    print(ur)

#Fetching Image------------------------------------------------------------------------------
opener=urllib.request.build_opener()
opener.addheaders=[('User-Agent','Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1941.0 Safari/537.36')]
urllib.request.install_opener(opener)

filename = 'temp.png'

image_url = imgUrls[random.randint(2,len(imgUrls) -3)]


#image_url = image_url.replace("\\", "")
#image_url = image_url.replace("//", "")
#if(image_url.__contains__("https://") == False):
 #   image_url = image_url.replace("https:", "https://")

print( "\n" + image_url )
urllib.request.urlretrieve(image_url, filename)





wrapper = textwrap.TextWrapper(width=30) 
word_list = wrapper.wrap(text=msgTop) 
msgWrappedTop = ''
for ii in word_list[:-1]:
    msgWrappedTop = msgWrappedTop + ii + '\n'
if msgTop != '':
    msgWrappedTop += word_list[-1]

wrapper = textwrap.TextWrapper(width=30) 
word_list = wrapper.wrap(text=msgBottom) 
msgWrappedBottom = ''
for ii in word_list[:-1]:
    msgWrappedBottom = msgWrappedBottom + ii + '\n'
if msgBottom != '':
    msgWrappedBottom += word_list[-1]

def fade_image(image, p1, p2, flow_up=False):
    fade_range = list(range(int(height*p1), int(height*p2)))
    fade_range = fade_range[::-1] if flow_up else fade_range
    for y in fade_range:
        if flow_up:
            alpha = int((y - height*p1)/height/(p2-p1) * 255)
        else:
            alpha = 255-int((y - height*p1)/height/(p2-p1) * 255)
        for x in range(width):
            pixels[x, y] = pixels[x, y][:3] + (alpha,) 


#Editing Image------------------------------------------------------------------------------
img = Image.open(filename)
img = img.resize((500,500))
fnt = ImageFont.truetype("impact.ttf", 40)
img.putalpha(255)
width, height = img.size
pixels = img.load()

#fade_image(pixels, 0.9, 1. , flow_up=False)
#fade_image(pixels, 0  , 0.1, flow_up=True)

I1 = ImageDraw.Draw(img)
w, h = I1.textsize(msgWrappedTop ,font=fnt)
w2, h2 = I1.textsize(msgWrappedBottom ,font=fnt)

I1.text(((500-w)/2,0), msgWrappedTop,font=fnt, align='center',fill=(255, 255, 255), stroke_fill=(0,0,0,255), stroke_width=3)
I1.text(((500-w2)/2, height-50), msgWrappedBottom, font=fnt, align='center',fill=(255, 255, 255), stroke_fill=(0,0,0,255), stroke_width=3)


img.save("done.png")