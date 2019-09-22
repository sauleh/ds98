---
layout: page
title: Assignments
permalink: /assignments/
---

You can download the assignments here (in PDF format). Also check out assignment's pages for any additional info.

**Instructor's account and TA's shared account must be given admin access to AzureDevOps.** Please see instructions [here](../static_files/docs/AdminAccess.pdf).

Also please see [this](https://drive.iust.ac.ir/index.php/s/S9pCGxfQQdumMmE/download?path=%2FVideos&files=Pipeline.mp4) for creating the correct **build pipeline** for .NET Core in AzureDevOps. 

<ul id="archive">
{% for asg in site.assignments reversed %}
      <li class="archiveposturl" style="background: transparent">
        <span><a href="{{ asg.url | prepend: site.baseurl}}">{{ asg.title }}</a></span>
<strong style="font-size:100%; font-family: 'Titillium Web', sans-serif; float:right">
<a title="Download problems (pdf)" href="{{ asg.pdf | prepend: site.baseurl }}"><i class="fas fa-file-pdf"></i></a> 
{% if asg.attachment %}
&nbsp; <a title="Download attachments (zip)" href="{{ asg.attachment | prepend: site.baseurl }}"><i class="fas fa-file-archive"></i></a>
{% endif %}
</strong> 
      </li>
{% endfor %}
</ul>