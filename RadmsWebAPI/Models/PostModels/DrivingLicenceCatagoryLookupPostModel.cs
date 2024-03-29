﻿using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class DrivingLicenceCatagoryLookupPostModel
    {
        public int DrivingLicenceCatagoryId { get; set; }

        public string DrivingLicenceCatagoryName { get; set; } = null!;
        public DrivingLicenceCatagoryLookupPostModel()
        {

        }
        public DrivingLicenceCatagoryLookupPostModel(DrivingLicenceCatagoryLookupEntity entity)
        {
            this.DrivingLicenceCatagoryId = entity.DrivingLicenceCatagoryId;
            this.DrivingLicenceCatagoryName = entity.DrivingLicenceCatagoryName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            DrivingLicenceCatagoryLookupEntity entity = new DrivingLicenceCatagoryLookupEntity();
            entity.DrivingLicenceCatagoryId = this.DrivingLicenceCatagoryId;
            entity.DrivingLicenceCatagoryName = this.DrivingLicenceCatagoryName;
            return entity as T;
        }
    }
}
