---
layout: page
title: Lectures
permalink: /lectures/
---

You can download the lectures here (in PDF format). I will try to upload lectures prior to their corresponding classes. 

For students who have [signed](https://www.signupgenius.com/go/20f0b4da9a72fa1fa7-note) up to take notes, they should create an account with overleaf.com. Please note you need a VPN connection to log onto Overleaf. Then select "New Project" and then select "View All" under "Templates". Then search for "IUST Student Course Note Template". Once you find the correct template, select "Open as Template". Once the template is opened, make sure "XeLaTeX" is selected as the compiler in the menu and that it compiles correctly. Then start by opening the session.tex file, updating the Subject, Author, Date, ... fields and start creating notes. Notes should be taken in Farsi. Please note that the Overleaf editor is not the easiest editor to work with when typing Farsi and English. Keeping different languages on seperate lines helps. You can select the "Rich Text" editor or just copy-past the text into your local editor and then paste it back when you are done editing and ready to compile. Alrternatively you can download MikTeX and TeXStudio and edit it on your local box. Once you are done, rename your project to IUST_DS98_SessionX (replace X by session number) and share it with my email (first name, at gmail). Please let me know if you have any questions.

Alternatively, you can download the latex template from [here](../statc_files/resources/ds98notes_template.zip) and upload it to overleaf or use TeXStudio (or other LaTeX editor/compilers) intead.


<ul id="archive">
{% for lecture in site.lectures reversed %}
<li class="archiveposturl" style="background: transparent">
<div class="lecture-container">
    {% if lecture.thumbnail %}
    <div class="thumbnail">
      <div class="center-cropped" style="margin-top:5px;margin-bottom:5px;background-image: url('{{ lecture.thumbnail | prepend: site.baseurl }}');">
        <img src="{{ lecture.thumbnail | prepend: site.baseurl }}"/>
      </div>
    </div>
    {% endif %}
    <div class="content">
        <span><a href="
            {% if lecture.slides contains '://' %}
              {{ lecture.slides }} 
            {% else %}
              {{ lecture.slides | prepend: site.baseurl }} 
            {% endif %}">{{ lecture.title }}</a>
        </span><br>

        {% if lecture.tldr %}
            <strong>tl;dr:</strong> 
            {{ lecture.tldr }}
            <br/>
        {% endif %}

        <strong>
            {% include lecture_links.html lecture=lecture %}
        </strong>
    </div>
</div>
</li>
{% endfor %}
</ul>