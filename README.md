  <ul>
  {% for post in site.posts %}
      Publicado dia {{ post.date | date: '%d de %B de %Y' }} em {{ post.categories | join: ', ' }}
      <h2><a href="{{ site.baseurl }}{{ post.url }}">{{ post.title }}</a></h2>
      {{ post.excerpt }}
  {% endfor %}
  </ul>
