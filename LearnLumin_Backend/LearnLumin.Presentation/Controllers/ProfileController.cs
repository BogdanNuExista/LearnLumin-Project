using LearnLumin.BLL.Interfaces;
using LearnLumin.DAL.DTOs.UserAndRoles;
using Microsoft.AspNetCore.Mvc;

namespace LearnLumin.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProfileController : ControllerBase
{
     private readonly IProfileService _profileService;
     
     public ProfileController(IProfileService profileService)
     {
         _profileService = profileService;
     }
     
     [HttpGet("GetAllProfiles")]
     public async Task<IActionResult> GetAllProfilesAsync()
     {
         var profiles = await _profileService.GetAllProfilesAsync();
         return Ok(profiles);
     }
     
     [HttpGet("GetProfileById/{id}")]
     public async Task<IActionResult> GetProfileByIdAsync(string id)
     {
         var profile = await _profileService.GetProfileByIdAsync(id);
         return Ok(profile);
     }
     
     [HttpPost("CreateProfile")]
     public async Task<IActionResult> CreateProfileAsync([FromBody] ProfileRequestDto profileRequestDto)
     {
         var profile = await _profileService.CreateProfileAsync(profileRequestDto);
         return Ok(profile);
     }
     
     /*
     [HttpPut("UpdateProfile/{id}")]
     public async Task<IActionResult> UpdateProfileAsync(string id, [FromBody] ProfileRequestDto profileRequestDto)
     {
         var profile = await _profileService.UpdateProfileAsync(id, profileRequestDto);
         return Ok(profile);
     }
     
     // this method is gonna be in the user controller
     */
     
     [HttpDelete("DeleteProfile/{id}")]
     public async Task<IActionResult> DeleteProfileAsync(string id)
     {
         var deletedProfile = await _profileService.DeleteProfileAsync(id);
         return Ok(deletedProfile);
     }
     
     
}