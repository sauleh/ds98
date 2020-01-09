---
layout: page
title: Exams
permalink: /exams/
---
<ul id="archive">
{% assign all_events = site.events | where_exp:"item", "item.type == 'exam'" | sort: 'date' %}
{% for asg in all_events reversed %}
      <li class="archiveposturl" style="background: transparent">
        <span><strong style="font-size:100%; font-family: 'Titillium Web', sans-serif;">{{ asg.description }}</strong></span>
        <strong style="font-size:100%; font-family: 'Titillium Web', sans-serif; float:right">

        {% if asg.attachment %}
        &nbsp; <a title="Download attachments (zip)" href="{{ asg.attachment | prepend: site.baseurl }}">
        <i class="fas fa-file-archive"></i>
        </a>
        {% endif %}

        {% if asg.examdoc %}
        &nbsp; <a title="Exam" href="{{ asg.examdoc | prepend: site.baseurl }}">
        <i class="fas fa-file-pdf"></i></a>
        {% endif %}

        {% if asg.solution %}
        &nbsp; <a title="Solution" href="{{ asg.solution | prepend: site.baseurl }}">
        <i class="fas fa-file-pdf"></i>
        </a>
        {% endif %}

        </strong> 
      </li>
{% endfor %}
</ul>