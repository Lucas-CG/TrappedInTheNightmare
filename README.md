  <ul>
  {% for post in site.posts %}
      Publicado dia {{ post.day }}/{{ post.month }}/{{ post.year }} em {{ page.categories | join: ', ' }}
      <h2><a href="{{ site.baseurl }} {{ post.url }}">{{ post.title }}</a></h2>
      {{ post.excerpt }}
  {% endfor %}
  </ul>
