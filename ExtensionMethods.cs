namespace CourseProject
{
    public static class ExtensionMethods
    {
        public static int PercentOf(this int left, int right)
        {
            if (left < 0)
                left = 0;
            else if (left > 100)
                left = 100;

            var v = left / 100.0;
            return (int)(v * right);
        }

        public static float PercentOf(this int left, float right)
        {
            var v = left / 100f;
            return v * right;
        }

        public static System.Drawing.PointF Downscale(this System.Drawing.PointF point, float scale)
        {
            return new System.Drawing.PointF(point.X / scale, point.Y / scale);
        }
        public static System.Drawing.PointF Upscale(this System.Drawing.PointF point, float scale)
        {
            return new System.Drawing.PointF(point.X * scale, point.Y * scale);
        }
    }
}
