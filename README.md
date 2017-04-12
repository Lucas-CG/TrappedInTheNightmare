<ul>
  {% for post in site.posts %}
    <li>
      Publicado dia {{ post.day }}/{{ post.month }}/{{ post.year }} em {{ page.categories | join: ', ' }}
      <a href="{{ post.url }}">{{ post.title }}</a>
      {{ post.excerpt }}
    </li>
  {% endfor %}
</ul>
