async function getUsers() {
  let url = "AddressBook";
  try {
    let res = await fetch(url);
    return await res.json();
  } catch (error) {
    console.log(error);
  }
}
async function renderUsers() {
  let users = await getUsers();
  let html = "";
  users.forEach((user) => {
    let htmlSegment = `
                        <div class = "card">
                            <div class="user">                            
                            <h3>NAME : ${user.name}</h3>
                            <div class ="card-body">
                            <h4> ADDRESS: ${user.address} , POSTCODE : ${user.postCode}</h4>
                            <h5>City/Country :${user.city} ${user.country}</h5>
                            </div>
                            </div>
                        </div>`;

    html += htmlSegment;
  });

  let container = document.querySelector(".jsData");
  container.innerHTML = html;
}

renderUsers();
