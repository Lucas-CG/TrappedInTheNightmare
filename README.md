<ul>
  {% for post in site.posts %}
    <li>
      {{ post.day }}/{{ post.month }}/{{ post.year }} em {{ post.categories }}
      <a href="{{ post.url }}">{{ post.title }}</a>
      {{ post.excerpt }}
    </li>
  {% endfor %}
</ul>
