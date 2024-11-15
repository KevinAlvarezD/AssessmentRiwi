using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Users
{
    public partial class UsersController : ControllerBase
    {
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userRepository.CheckExistence(id);
            if (user == false)
            {
                return NotFound();
            }

            await _userRepository.Delete(id);

            return NoContent();
        }
    }
}